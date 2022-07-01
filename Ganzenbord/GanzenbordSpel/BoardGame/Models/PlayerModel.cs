using GanzenbordLib;

namespace BoardGame.Models
{
    public class PlayerModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; } = 0;
        public string Color { get; set; }
        public static PlayerModel Create(Pion p)
        {
            if (p == null) return null;
            return new PlayerModel
            {
                Id = p.Id,
                Name = p.Naam,
                Position = p.Positie,
                Color = p.Kleur
            };
        }
    }
}
