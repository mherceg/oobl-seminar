using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tracktor.WebService.Models
{
    public class RateInfoPostDTO
    {
        [Required]
        public int userId { get; set; }
        [Required]
        public int infoId { get; set; }
        [Required]
        public bool score { get; set; }
    }
}