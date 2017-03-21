using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaptivePortal.API.Controllers
{
    public class AdminIndexController : Controller
    {
        // GET: AdminIndex
        public ActionResult Index()
        {
            return View();
        }
    }
}