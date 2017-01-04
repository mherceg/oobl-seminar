using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Newtonsoft.Json;
using Tracktor.Domain;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Input;
using Windows.UI;

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
            page.Map.ZoomLevel = 16;            

            ServiceRepository serviceRepository = new ServiceRepository();
            List<PlaceEntity> places = await serviceRepository.getPlaces();

            // calculate center of all places
            GeoCoordinate centerCoordinate = new GeoCoordinate(0, 0);
            foreach (PlaceEntity place in places)
            {
                centerCoordinate.Latitude += place.Location.Latitude;
                centerCoordinate.Longitude += place.Location.Longitude;

                var geopoint = new Geopoint
                (
                    new BasicGeoposition()
                    {
                        Latitude = place.Location.Latitude,
                        Longitude = place.Location.Longitude
                    }
                );

                StackPanel pin = new StackPanel();

                Image pinImage = new Image
                {
                    Width = 64,
                    Height = 64,
                    Source = new BitmapImage(new Uri("ms-appx:///Assets/PlaceIcon.png")),
                };

                TextBlock pinText = new TextBlock
                {                                        
                    Text = place.Name,  
                    TextWrapping = TextWrapping.NoWrap,  
                    FontSize = 20,
                    Foreground = new SolidColorBrush(Color.FromArgb(255,0,0,0))                                   
                };
                
                pin.Tapped += new TappedEventHandler(PinTapped);

                pin.Children.Add(pinImage);
                pin.Children.Add(pinText);

                // Add XAML to the map.
                page.Map.Children.Add(pin);
                MapControl.SetLocation(pin, geopoint);
                MapControl.SetNormalizedAnchorPoint(pin, new Point(0.5, 0.5));

            }
            centerCoordinate.Latitude /= places.Count;
            centerCoordinate.Longitude /= places.Count;

            var center = new Geopoint
                (
                    new BasicGeoposition()
                    {
                        Latitude = centerCoordinate.Latitude,
                        Longitude = centerCoordinate.Longitude
                    }
                );

            // retrieve map
            await page.Map.TrySetViewAsync(center);
        }

        private void PinTapped(object sender, RoutedEventArgs e)
        {            
            page.Frame.Navigate(typeof(PlaceInfoPage));
        }
    }
}
