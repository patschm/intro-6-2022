using GanzenbordLib;

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
        public bool IsStarted { get => Board.IsStarted; set => Board.Start(); }
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
            if (Players.Count == 1)
            {
                OwnerId = p.Id;
            }
            var player = PlayerModel.Create(p);
            return player;
        }
    }
}
