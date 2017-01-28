using System;
using System.Collections.Generic;
using System.Linq;

namespace Tracktor.WebService.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public System.DateTime time { get; set; }
        public string user { get; set; }
        public string content { get; set; }
        public int reputation { get; set; }
    }
}