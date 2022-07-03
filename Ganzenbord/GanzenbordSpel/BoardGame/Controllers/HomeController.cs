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

        // Should be in a database
        private static readonly List<GameModel> _games = new List<GameModel>();

        public HomeController(IHubContext<GameHub> hub ,ILogger<HomeController> logger)
        {
            _hub = hub;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_games);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GameModel model)
        {
            model.Id = Guid.NewGuid().ToString();
            model.Register(User.Identity.Name);
            _games.Add(model);
            return RedirectToAction("Play", new { gameId = model.Id });
        }
        
        public async Task Start(string gameId)
        {
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            game.Start(_hub);
            await _hub.Clients.Group(gameId).SendAsync("started", GameState.Create(game));
        }
        public async Task State(string gameId)
        {
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            await _hub.Clients.Group(gameId).SendAsync("changeState", GameState.Create(game));
        }
        public IActionResult Play(string gameId)
        {
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            var p = game.Register(User.Identity.Name);
            if (p == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.UserId = p.Id;
            ViewBag.UserName = p.Name;
            ViewBag.UserColor = p.Color;
             return View("Play", game);
        }
        public IActionResult Leave(string gameId)
        {
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            game.Unregister(User.Identity.Name);

            return RedirectToAction("Index");
        }
        public async Task Throw(string gameId)
        {
            var game = _games.FirstOrDefault(g => g.Id == gameId);
            if (game.IsEnded) return;
            game.Board.Beurt();
            await _hub.Clients.Group(gameId).SendAsync("throw", new { 
                Id = game.ActivePlayer.Id,
                Name = game.ActivePlayer.Name, 
                Color = game.ActivePlayer.Color,
                Dice1 = game.Board.Steen1.Worp, 
                Dice2 = game.Board.Steen2.Worp
            });
            await _hub.Clients.Group(gameId).SendAsync("changeState", GameState.Create(game));
            game.Board.Next();
            await _hub.Clients.Group(gameId).SendAsync("nextturn", GameState.Create(game));
        }
    }
}