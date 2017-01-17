using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// REMEMBER to create Starup.cs file 

namespace MvcSignalR.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        // Send message to all SignalR clients
        [HttpPost]
        public ActionResult Index(string message) {
            IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            hubContext.Clients.All.addNewMessageToPage("Server says", message);
            return View();
        }

        public ActionResult Listener() {
            return View();
        }
    }
}