using BoardGame.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BoardGame.Hubs
{
    public class GameState
    {
        public List<PlayerState> Players { get; set; }
        public PlayerState CurrentPlayer { get; set; }
        public bool IsEnded { get; private set; }

        public static GameState Create(GameModel model)
        {
            GameState state = new GameState { };
            state.Players = model.Players.Select(p=>PlayerState.Create(p)).ToList();
            state.CurrentPlayer = PlayerState.Create(model.ActivePlayer);
            state.IsEnded = model.IsEnded;
            return state;
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }
    }
}
