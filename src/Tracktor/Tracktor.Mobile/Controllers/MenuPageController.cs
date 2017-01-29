using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Mobile.Pages;

namespace Tracktor.Mobile.Controllers
{
    class MenuPageController
    {
        private MenuPage page = null;
        public MenuPageController(MenuPage page)
        {
            this.page = page;

            if (SessionManager.IsPremium())
            {
                page.sponsorButton.IsEnabled = true;
            }
        }

        public void ShowMap()
        {
            page.Frame.Navigate(typeof(MapPage));
        }

        public void ShowFavorites()
        {
            page.Frame.Navigate(typeof(FavoritesPage));
        }

        public void ShowSposorship()
        {
            page.Frame.Navigate(typeof(SponsorshipPage));
        }
    }
}
