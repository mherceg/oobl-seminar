using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Business;
using Tracktor.Domain;
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
            var filters = getSearchFIlters(vm.Categories);

            var infoService = ServiceFactory.getInfoServices();
            vm.Results = infoService.GetByFilter(filters, true, true, vm.PlaceId);

            return View(vm);
        }

        private IDictionary<string, bool> getSearchFIlters(List<SelectListItem> categories)
        {
            var rv = new Dictionary<string, bool>();
            bool anySelected = false;
            foreach(var c in categories)
            {
                rv[c.Text] = c.Selected;
                if(c.Selected) { anySelected = true; }
            }
            if(!anySelected)
            {
                var r = new Dictionary<string, bool>();
                foreach(var k in rv.Keys)
                {
                    r[k] = true;
                }
                rv = r;
            }
            return rv;
        }

        public ActionResult ImpressionDetails()
        {
            return View();
        }
    }
}