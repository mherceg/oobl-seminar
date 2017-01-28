using System;
using System.Collections.Generic;
using System.Linq;
namespace Tracktor.WebService.Models
{
    public class CommentPostDTO
    {
        public System.DateTime time { get; set; }
        public int userId { get; set; }
        public int contentInfoId { get; set; }
        public string content { get; set; }
    }
}