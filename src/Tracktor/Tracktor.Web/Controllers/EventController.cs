using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Business;
using Tracktor.Web.ViewModels.Event;
using Tracktor.Web.ViewModels.User;

namespace Tracktor.Web.Controllers
{
    public class EventController : Controller
    {
        //GET: Search
        public ActionResult Search()
        {
            var categoryService = ServiceFactory.getCategoryServices();
            var categories = categoryService.ListAll();

            var placeService = ServiceFactory.getPlaceServices();
            var places = placeService.GetAll();

            var vm = new SearchVM();
            foreach(var c in categories)
            {
                vm.Categories.Add(new SelectListItem
                {
                    Selected = false,
                    Text = c.Name,
                    Value = c.Id.ToString(),
                });
            }
            vm.Places = places;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Search(SearchVM vm)
        {
            return View(vm);
        }

        public ActionResult ImpressionDetails()
        {
            return View();
        }
    }
}