using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tracktor.Web.ViewModels.Place
{
    public class AddPlaceVM
    {
        public string Name { get; set; }

        [Display(Name = "Latitude")]
        public string Lat { get; set; }

        [Display(Name = "Longitude")]
        public string Lng { get; set; }
    }
}