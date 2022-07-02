using BoardGame.Hubs;
using GanzenbordLib;
using Microsoft.AspNetCore.SignalR;

namespace BoardGame.Models
{
    public class GameModel
    {
        private string[] colors = { "aqua", "red", "yellow", "blue", "green", "grey" };
        private Bord _bord = new Bord();
        public Bord Board { get => _bord; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; private set; }
        public string OwnerName { get; private set; }
        public bool IsStarted { get => Board.IsStarted; }
        public bool IsEnded { get => Board.IsBeeindigd; }
        public PlayerModel ActivePlayer { get => PlayerModel.Create(Board.ActievePion); }
       
        public List<PlayerModel> Players
        {
            get
            {
                return Board.Spelers
                    .Select(p => PlayerModel.Create(p))
                    .ToList();

            }
        }
        public PlayerModel Register(string name)
        {          
            Pion p = Board.Registreer(name, colors[Players.Count]);
            var pion = Players.FirstOrDefault();
            if (pion != null)
            {
                OwnerId = pion.Id;
                OwnerName = pion.Name;
            }
            
            var player = PlayerModel.Create(p);
            return player;
        }
        public void Unregister(string name)
        {
            Board.SchijfUit(name);
            if (Players.Count == 0)
            {
                OwnerId = "";
                OwnerName = "None";
                return;
            }
            var pion = Players.FirstOrDefault();
            OwnerId = pion.Id;
            OwnerName = pion.Name;
        }
        public void Start(IHubContext<GameHub> hub)
        {
            Console.SetOut(new HubWriter(hub, Id));
            Board.Start();
        }
    }
}
