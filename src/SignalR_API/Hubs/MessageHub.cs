using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_API.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendName(string name)
        {
            await Clients.All.SendAsync("ReceiveName", name);
        }
    }
}
