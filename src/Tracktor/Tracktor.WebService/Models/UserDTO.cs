using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tracktor.Domain;

namespace Tracktor.WebService.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public int UserTypeId { get; set; }
    }
}