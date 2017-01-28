using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Domain;

namespace Tracktor.Web.ViewModels.Place
{
    public class AddPlaceToListVM
    {
        public List<PlaceEntity> Places { get; set; } = new List<PlaceEntity>();

        public int PlaceId { get; set; } = -1;

        public string PlaceName { get; set; }

        public SelectListItem FavouritePlace { get; set; } = new SelectListItem { Selected = false, Text = "Favourite place", Value = "false" };

        public SelectListItem SponsoredPlace { get; set; } = new SelectListItem { Selected = false, Text = "Sponsored place", Value = "false" };
    }
}