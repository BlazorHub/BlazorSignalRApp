using System.Threading.Tasks;
using BlazorSignalRApp.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRApp.Server.Hubs {

    public class ComplexHub: Hub {

        public async Task SendMessage(Notification notification)
        {
            await Clients.All.SendAsync("ReceiveMessage", notification);
        }

    }
}