using BoardGame.Models;

namespace BoardGame.Hubs
{
    public class PlayerState
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public string Color { get; set; }
        public static PlayerState Create(PlayerModel p)
        {
            if (p == null) return null;
            return new PlayerState
            {
                Id = p.Id,
                Name = p.Name,
                Position = p.Position,
                Color = p.Color
            };
        }
    }
}
