using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Web.ViewModels.Home;

namespace Tracktor.Web.Controllers
{
    public class HomeController : Controller
    {
        //GET: LogIn
        public ActionResult LogIn()
        {
            return View(new LogInVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(LogInVM vm)
        {
            return RedirectToAction(nameof(Search));
        }

        //GET: Index
        public ActionResult Index()
        {
            return View();
        }

        //GET: Search
        public ActionResult Search()
        {
            return View();
        }

        public ActionResult ImpressionDetails()
        {
            return View();
        }
    }
}