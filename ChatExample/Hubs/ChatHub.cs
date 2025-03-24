using Microsoft.AspNetCore.SignalR;

namespace ChatExample.Hubs;

public interface IChatClient
{
    Task ReceiveMessage(string message);
}

public class ChatHub : Hub<IChatClient>
{
    public async Task SendMessage(string message)
    {
        await Clients.Others.ReceiveMessage(message);
    }
}