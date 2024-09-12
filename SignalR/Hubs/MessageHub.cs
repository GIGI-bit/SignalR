using Microsoft.AspNetCore.SignalR;
using SignalR.Helpers;

namespace SignalR.Hubs
{
    public class MessageHub:Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveConnectInfo","User Connected");
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReciveMessage",message+"'s Offer : ",FileHelper.Read());
            
        }

    }
}
