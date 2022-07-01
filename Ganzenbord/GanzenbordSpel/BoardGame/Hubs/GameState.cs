using BoardGame.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BoardGame.Hubs
{
    public class GameState
    {
        public List<PlayerState> Players { get; set; } = new List<PlayerState>();
        public PlayerState Current { get; set; }
        public int Eyes { get; set; } = 0;

        public static GameState Create(GameModel model)
        {
            GameState state = new GameState { };
            foreach(var pl in model.Players)
            {
                state.Players.Add(new PlayerState { Id = pl.Id, Name = pl.Name, Position=pl.Position });
            }
            state.Current = state.Players.FirstOrDefault();
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
