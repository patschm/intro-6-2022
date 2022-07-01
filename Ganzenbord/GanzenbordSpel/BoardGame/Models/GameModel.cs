namespace BoardGame.Models
{
    public class GameModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public bool IsStarted { get; set; } = false;
        public bool IsEnded { get; set; } = false;
        public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();
        public PlayerModel ActivePlayer { get; set; }
    }
}
