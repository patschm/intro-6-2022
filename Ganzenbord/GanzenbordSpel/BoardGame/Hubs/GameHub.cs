using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BoardGame.Hubs
{
    public class GameHub: Hub
    {
        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
        public async Task JoinGame(string connectionId, string gameId, string id, string name, string color)
        {
            await Groups.AddToGroupAsync(connectionId, gameId);
            await Clients.Group(gameId).SendAsync("register", new { Id=id, Name = name, Color = color, GameId = gameId });
        }
        public async Task LeaveGame(string connectionId, string gameId, string id, string name, string color)
        {
            await Groups.RemoveFromGroupAsync(connectionId, gameId);
            await Clients.Group(gameId).SendAsync("unregister", new { Id=id, Name = name, Color = color, GameId = gameId });
        }
    }
}
