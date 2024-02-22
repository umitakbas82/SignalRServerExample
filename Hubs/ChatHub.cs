using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.SignalR;
using SignalRServerExample.Data;
using SignalRServerExample.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServerExample.Hubs
{
    public class ChatHub:Hub
    {
        public async Task GetNickName(string nickName)
        {
            Client client = new Client()
            {
                ConnectionId = Context.ConnectionId,
                NickName = nickName
            };

            ClientSource.Clients.Add(client);
            Clients.Others.SendAsync("clientJoined", nickName);
        }
    }
}
