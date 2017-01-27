using System;
using System.Collections.Generic;
using System.Linq;

namespace Tracktor.WebService.Models
{
    public class UserPostDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int UserTypeId { get; set; }
    }
}