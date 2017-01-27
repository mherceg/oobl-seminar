using System;
using System.Collections.Generic;
using System.Linq;

namespace Tracktor.WebService.Models
{
    public class RateInfoPostDTO
    {
        public int userId { get; set; }
        public int infoId { get; set; }
        public bool score { get; set; }
    }
}