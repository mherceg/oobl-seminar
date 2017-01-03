using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    public class GeoCoordinate
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public GeoCoordinate(double? Latitude, double? Longitude)
        {
            this.Longitude = Longitude.Value;
            this.Latitude = Latitude.Value;
        }
    }
}
