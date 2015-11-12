using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMessaging.Models;
namespace WebMessaging.Controllers
{
    public class HomeController : Controller
    {
        private MessageCollection collection = new MessageCollection();
        public ActionResult Index()
        {
            return View(collection);
        }
    }
}