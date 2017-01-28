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
    class FavoritesPageController
    {
        private FavoritesPage page = null;

        public FavoritesPageController(FavoritesPage page)
        {
            this.page = page;
        }

        public async Task InitFavorites()
        {
            ServiceRepository serviceRepository = new ServiceRepository();

            var favorites = await serviceRepository.getFavourites();

            foreach (var favorite in favorites)
            {
                Button b = new Button()
                {
                    Content = favorite.Name,
                    HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch,
                    VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch
                };

                b.Click += new RoutedEventHandler(delegate (object o, RoutedEventArgs e)
                {
                    page.Frame.Navigate(typeof(InformationListPage), favorite);
                }
                );

                page.FavoritesPanel.Children.Add(b);
            }
        } 
    }
}
