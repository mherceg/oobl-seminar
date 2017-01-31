using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Domain;

namespace Tracktor.Desktop
{
	class CustomPlace
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }

		public CustomPlace(PlaceEntity place)
		{
			this.Id = place.Id;
			this.Name = place.Name;
			this.Latitude = place.Location.Latitude;
			this.Longitude = place.Location.Longitude;
		}

		public PlaceEntity CustomToDomain()
		{
			PlaceEntity place = new PlaceEntity();
			place.Id = this.Id;
			place.Name = this.Name;
			place.Location = new GeoCoordinate(Latitude, Longitude);

			return place;
		}
	}
}
