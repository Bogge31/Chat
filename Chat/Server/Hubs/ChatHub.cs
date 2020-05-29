using Chat.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendChat(string from, string message)
        {
            await Clients.All.SendAsync("ChatSent", new ChatMessage
            {
                From = from,
                Message = message,
                At = DateTime.Now
            });
        }
    }
}
