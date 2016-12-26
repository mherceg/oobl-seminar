using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
    }
}
