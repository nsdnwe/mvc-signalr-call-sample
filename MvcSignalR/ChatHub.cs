using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MvcSignalR {
    public class ChatHub : Hub {
        public void SendAll(string name, string message) {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}