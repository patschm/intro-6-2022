using Microsoft.AspNetCore.SignalR;
using System.Text;

namespace BoardGame.Hubs
{
    public class HubWriter : TextWriter
    {
        private IHubContext<GameHub> _hub;
        private string _gameId;

        public HubWriter(IHubContext<GameHub> hub, string gameId)
        {
            _hub = hub;
            _gameId = gameId;
        }

        public override Encoding Encoding => Encoding.Default;
        public override void WriteLine(string value)
        {
            _hub.Clients.Group(_gameId).SendAsync("message", value);
        }
    }
}
