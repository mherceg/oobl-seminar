using System;
using System.Collections.Generic;
using System.Linq;


namespace Tracktor.WebService.Models
{
    public class RateCommentPostDTO
    {
        public int userId { get; set; }
        public int commentId { get; set; }
        public bool score { get; set; }
    }
}