using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tracktor.WebService.Models
{
    public class InfoPostDTO
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string content { get; set; }


        public int userId { get; set; }
        public int categoryId { get; set; }
        public int placeId { get; set; }
    }
}