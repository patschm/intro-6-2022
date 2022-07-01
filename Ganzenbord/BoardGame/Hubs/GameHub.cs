using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BoardGame.Hubs
{
    public class GameHub: Hub
    {
       
       
        private GameState gameState = new GameState();
        
        //public async Task ThrowDices()
        //{
        //    var thrown  = random.Next(1, 13);

        //    await Clients.All.SendAsync("changeState", JsonConvert.SerializeObject(gameState, _settings));
        //}
        
        public void Reset()
        {
            gameState = new GameState();
        }
    }
}
