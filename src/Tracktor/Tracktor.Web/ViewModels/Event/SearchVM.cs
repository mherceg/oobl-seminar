using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Domain;

namespace Tracktor.Web.ViewModels.Event
{
    public class SearchVM
    {
        public List<PlaceEntity> Places { get; set; } = new List<PlaceEntity>();

        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        public SelectListItem ShowOnlyFavourite { get; set; } = new SelectListItem { Selected = false, Text = "Show only favourite places", Value = "false" };

        public int PlaceId { get; set; } = -1;

        public string PlaceName { get; set; } = "";
    }
}