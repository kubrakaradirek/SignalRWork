using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.SignalR;

namespace SignalRWork.Hubs
{
    public class ChatHub:Hub
    {
        //client ==> sunucuya gitmek için kullanılır
        public async Task SendMessage(string name,string message)
        {
            //server ==> clienta
            await Clients.All.SendAsync("NewMessage",name,message);
        }

        public async Task SendLocation(string color,int x,int y)
        {
            await Clients.All.SendAsync("LocationReceived",Context.ConnectionId,color,x,y);
        }
    }
}
