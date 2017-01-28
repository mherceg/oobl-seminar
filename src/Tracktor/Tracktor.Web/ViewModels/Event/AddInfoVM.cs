using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Domain;

namespace Tracktor.Web.ViewModels.Event
{
    public class AddInfoVM
    {
        [Display(Name = "Start time")]
        public DateTime StartTime { get; set; } = DateTime.Now;

        [Display(Name = "End time")]
        public DateTime EndTime { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Information content is required")]
        public string Content { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Information category is required")]
        public int SelectedCategoryId { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public List<PlaceEntity> Places { get; set; }

        [Display(Name = "Place")]
        public int PlaceId { get; set; }

        public string PlaceName { get; set; }
    }
}