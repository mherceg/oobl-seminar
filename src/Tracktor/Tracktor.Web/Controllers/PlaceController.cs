using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Business;
using Tracktor.Domain;
using Tracktor.Web.ViewModels.Place;

namespace Tracktor.Web.Controllers
{
    public class PlaceController : Controller
    {

        public ActionResult AddPlace()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPlace(AddPlaceVM vm)
        {
            var pe = new PlaceEntity
            {
                Location = new GeoCoordinate
                {
                    Latitude = double.Parse(vm.Lat, CultureInfo.InvariantCulture),
                    Longitude = double.Parse(vm.Lng, CultureInfo.InvariantCulture),
                },
                Name = vm.Name,
            };
            var placeService = ServiceFactory.getPlaceServices().Add(pe);

            return RedirectToAction("AddInfo", "Event");
        }

        public ActionResult AddPlaceToList()
        {
            var vm = new AddPlaceToListVM { Places = ServiceFactory.getPlaceServices().GetAll(), };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPlaceToList(AddPlaceToListVM vm)
        {
            var userId = (Session["user"] as UserEntity).Id;
            if (vm.PlaceId != -1)
            {
                var userService = ServiceFactory.getUserServices();
                if (vm.SponsoredPlace.Selected) { userService.AddSponsorPlace(userId, vm.PlaceId); }
                if (vm.FavouritePlace.Selected) { userService.AddFavouritePlace(userId, vm.PlaceId); }
            }

            return RedirectToAction("Search", "Event");
        }
    }
}