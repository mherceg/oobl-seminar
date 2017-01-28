using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    [DataContractAttribute]
    public class GeoCoordinate
    {
        [DataMemberAttribute]
        public double Longitude { get; set; }

        [DataMemberAttribute]
        public double Latitude { get; set; }

        public GeoCoordinate() { }

        public GeoCoordinate(double? Latitude, double? Longitude)
        {
            this.Longitude = Longitude.Value;
            this.Latitude = Latitude.Value;
        }
    }
}
