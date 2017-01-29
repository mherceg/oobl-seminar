using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Tracktor.Domain;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Tracktor.WebService.Models;
using Windows.UI.Xaml.Input;
using Tracktor.Mobile.Pages;

namespace Tracktor.Mobile
{
    class InformationListPageController
    {
        private InformationListPage page = null;

        private double defaultFavouriteOpacity = 0.4;

        public InformationListPageController(InformationListPage page)
        {
            this.page = page;

            page.Favourite.Visibility = Visibility.Collapsed;
        }
        public async Task InitInformations(PlaceEntity place)
        {
            ServiceRepository serviceRepository = new ServiceRepository();

            IEnumerable<InfoDTO> informations = await serviceRepository.getInfoDTO(place);

            foreach (var information in informations)
            {
                TextBlock t = new TextBlock()
                {
                    Text = information.content,
                    Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                    FontSize = 22
                };
                t.Tapped += new TappedEventHandler(delegate (object o, TappedRoutedEventArgs e)
                {
                    page.Frame.Navigate(typeof(InformationPage), information);
                }
                );
                page.InformationListbox.Items.Add(t);
            }

            //add button
            TextBlock addBlock = new TextBlock()
            {
                Text = "Dodaj novu...",
                Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                FontSize = 22
            };
            addBlock.Tapped += new TappedEventHandler(delegate (object o, TappedRoutedEventArgs e)
            {
                page.Frame.Navigate(typeof(AddInfoPage), place);
            }
            );
            page.InformationListbox.Items.Add(addBlock);

            List<PlaceEntity> favourites = await serviceRepository.getFavourites();

            bool isFavourite = favourites.Any(i => i.Id == place.Id);
            if (isFavourite)
                page.Favourite.Opacity = 1.0;

            page.Favourite.Visibility = Visibility.Visible;

            page.Favourite.Tapped += new TappedEventHandler(async delegate (object o, TappedRoutedEventArgs e)
            {
                page.Favourite.IsTapEnabled = false;

                if (isFavourite)
                {
                    await serviceRepository.removeFavourite(place.Id);
                    page.Favourite.Opacity = defaultFavouriteOpacity;
                }
                else
                {
                    await serviceRepository.addFavourite(place.Id);
                    page.Favourite.Opacity = 1.0;
                }

                page.Favourite.IsTapEnabled = true;
            });    
        }
    }
}
