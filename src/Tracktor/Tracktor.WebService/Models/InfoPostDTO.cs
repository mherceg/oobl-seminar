using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tracktor.WebService.Models
{
    public class InfoPostDTO
    {
        [Required]
        public DateTime startTime { get; set; }
        [Required]
        public DateTime endTime { get; set; }
        [Required]
        public string content { get; set; }

        [Required]
        public int userId { get; set; }
        [Required]
        public int categoryId { get; set; }
        [Required]
        public int placeId { get; set; }
    }
}