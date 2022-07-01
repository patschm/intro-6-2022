using BoardGame.Hubs;
using BoardGame.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;
using System.Security.Claims;

namespace BoardGame.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHubContext<GameHub> _hub;
        private static readonly List<GameModel> _games = new List<GameModel>();
        private static readonly Random random = new Random();

        public HomeController(IHubContext<GameHub> hub ,ILogger<HomeController> logger)
        {
            _hub = hub;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var usr = GetUserData();
            ViewBag.UserId = usr.Id;

            return View(_games);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GameModel model)
        {
            var usr = GetUserData();
            if (usr.Id == null) RedirectToAction("Login", "Account");
            model.OwnerId = usr.Id;
            model.IsStarted = false;
            model.IsEnded = false;
            model.Id = Guid.NewGuid().ToString();
            model.Players.Add(new PlayerModel { Id = usr.Id, Name = usr.Name });
            model.ActivePlayer = model.Players.FirstOrDefault();
            _games.Add(model);
            return RedirectToAction("Play", new { gameId = model.Id });
        }
        public IActionResult Play(string gameId)
        {
            ViewBag.Owner= User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            return View("Play", game);
        }
        public async Task<IActionResult> Start(string gameId)
        {
            var usr = GetUserData();
            ViewBag.Owner = usr.Id;
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            game.IsStarted = true;
            await _hub.Clients.All.SendAsync("changeState", GameState.Create(game));
            return View("Play", game);
        }
        public async Task<IActionResult> Join(string gameId)
        {
            var usr = GetUserData();
            ViewBag.UserId = usr.Id;
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            if (game.Players.FirstOrDefault(p => p.Id == usr.Id) == null)
            {
                game.Players.Add(new PlayerModel { Id = usr.Id, Name = usr.Name });
            }
            await _hub.Clients.All.SendAsync("register", new { User = usr.Name, GameId = game.Id });
            return View("Play", game);
        }
        public async Task State(string gameId)
        {
            var usr = GetUserData();
            var game = _games.FirstOrDefault(g => g.Id == gameId);
           
            await _hub.Clients.All.SendAsync("changeState", GameState.Create(game));
         }
        public async Task Throw(string gameId)
        {
            var usr = GetUserData();
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            if (!game.IsStarted) return;
            if (game.ActivePlayer.Id == usr.Id)
            {
                (int Dice1, int Dice2) dices = (random.Next(1, 7), random.Next(1,7));
                await _hub.Clients.All.SendAsync("throw", new { Name = usr.Name, Dice1 = dices.Dice1, Dice2 = dices.Dice2 });
                game.ActivePlayer.Position += dices.Dice1 + dices.Dice2;
                var stats = GameState.Create(game);
                await _hub.Clients.All.SendAsync("changeState", stats);
            }       
        }
        private (string Id, string Name) GetUserData()
        {
            var id = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var name = User.Identity.Name;
            return (id, name);
        }

    }
}