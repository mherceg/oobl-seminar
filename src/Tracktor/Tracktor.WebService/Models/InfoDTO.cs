using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tracktor.Domain;

namespace Tracktor.WebService.Models
{
    public class InfoDTO
    {
        public int Id { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string content { get; set; }
        public string category { get; set; }
        public string user { get; set; }
        public string place { get; set; }
        public int reputation { get; set; }
        
        public IEnumerable<CommentDTO> comments { get; set; }

    }
}