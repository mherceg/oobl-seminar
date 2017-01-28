using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Business;
using Tracktor.Domain;
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
            var userService = ServiceFactory.getUserServices();
            var le = new LoginEntity { Username = vm.Username, Password = vm.Password };
            try
            {
                var userId = userService.Login(le);
                var user = userService.Get(userId);
                Session["user"] = user;
                return RedirectToAction("Search", "Event");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(vm);
            }
        }

        //GET: LogOut
        public ActionResult LogOut()
        {
            Session["user"] = null;
            return RedirectToAction(nameof(LogIn));
        }
    }
}