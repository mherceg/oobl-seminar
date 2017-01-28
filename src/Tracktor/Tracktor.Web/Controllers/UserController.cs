using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Web.ViewModels.User;

namespace Tracktor.Web.Controllers
{
    public class UserController : Controller
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
            return RedirectToAction("Search", "Event");
        }

        //GET: LogOut
        public ActionResult LogOut()
        {
            return RedirectToAction(nameof(LogIn));
        }
    }
}