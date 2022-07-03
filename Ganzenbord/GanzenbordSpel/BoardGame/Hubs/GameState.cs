using BoardGame.Models;

namespace BoardGame.Hubs
{
    public class GameState
    {
        public List<PlayerState> Players { get; set; }
        public PlayerState Current { get; set; }
        public bool IsEnded { get; private set; }
        public bool IsStarted { get; set; }

        public static GameState Create(GameModel model)
        {
            return new GameState {
                Players = model.Players.Select(p=>PlayerState.Create(p)).ToList(),
                Current = PlayerState.Create(model.ActivePlayer),
                IsStarted = model.IsStarted,
                IsEnded = model.IsEnded
            };
        }
    }
}
