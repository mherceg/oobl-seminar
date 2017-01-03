using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Newtonsoft.Json;

namespace Tracktor.Mobile
{
    class MapPageController
    {
        private MapPage page = null;

        public MapPageController(MapPage mainPage)
        {
            this.page = mainPage;
        }
        public async Task MapLoaded()
        {
            page.Map.ZoomLevel = 12;

            Tracktor.Domain.PlaceEntity place = new Domain.PlaceEntity()
            {
                Id = 0,
                Location = new Domain.GeoCoordinate(45.8128451, 15.9753062),
                Name = "AYY LMAO"
            };

            ServiceRepository serviceRepository = new ServiceRepository();
            await serviceRepository.getPlaces();

            //JsonConvert.SerializeObject();

            var center = new Geopoint
                (
                    new BasicGeoposition()
                    {
                        Latitude = place.Location.Latitude,
                        Longitude = place.Location.Longitude
                    }
                );

            // retrieve map
            await page.Map.TrySetViewAsync(center);
        }
    }
}
