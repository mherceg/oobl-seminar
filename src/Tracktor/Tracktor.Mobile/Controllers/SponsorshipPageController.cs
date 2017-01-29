using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Mobile.Pages;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Tracktor.Mobile.Controllers
{
    class SponsorshipPageController
    {
        private SponsorshipPage page = null;

        public SponsorshipPageController(SponsorshipPage page)
        {
            this.page = page;
        }

        public async Task InitSponsored()
        {
            ServiceRepository serviceRepository = new ServiceRepository();

            var sponsored = await serviceRepository.getSponsored();

            foreach (var place in sponsored)
            {
                Button b = new Button()
                {
                    Content = place.Name,
                    HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch,
                    VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch
                };

                b.Click += new RoutedEventHandler(delegate (object o, RoutedEventArgs e)
                {
                    page.Frame.Navigate(typeof(AddInfoPage), new AddInfoParameter() { place = place, lat = 0, lon = 0 });
                }
                );

                page.SponsorPanel.Children.Add(b);
            }
        }
    }
}
