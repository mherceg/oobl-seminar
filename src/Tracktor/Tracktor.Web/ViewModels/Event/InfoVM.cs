using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tracktor.Web.ViewModels.Event
{
    public class InfoVM
    {
        public class Comment
        {
            public int Id { get; set; }

            public string Username { get; set; }

            public string Content { get; set; }

            public int Reputation { get; set; }
        }

        public int Id { get; set; }

        [Display(Name = "Time from")]
        public DateTime Time { get; set; }

        [Display(Name = "Time to")]
        public DateTime EndTime { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        [Display(Name = "From user")]
        public string FromUser { get; set; }

        public int PlaceId { get; set; }

        [Display(Name = "For place")]
        public string PlaceName { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public int Reputation { get; set; }
    }
}