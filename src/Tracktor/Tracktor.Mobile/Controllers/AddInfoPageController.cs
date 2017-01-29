using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Mobile.Pages;
using Tracktor.Domain;
using Windows.UI.Xaml;
using Tracktor.WebService.Models;

namespace Tracktor.Mobile.Controllers
{
    class AddInfoPageController
    {
        private AddInfoPage page = null;
        public AddInfoPageController(AddInfoPage page)
        {
            this.page = page;            
        }

        public async Task Init(AddInfoParameter parameter)
        {
            PlaceEntity place = parameter.place;

            if (place == null)
            {
                page.PlaceName.IsEnabled = true;
            }
            else
            {
                page.PlaceName.Text = place.Name;
            }

            ServiceRepository serviceRepository = new ServiceRepository();

            List<PlaceEntity> sponsored = await serviceRepository.getSponsored();

            bool isSponsored = sponsored.Any(i => i.Id == place.Id);
            if (isSponsored)
            {
                page.VrijemeOd.IsEnabled = true;
                page.DatumOd.IsEnabled = true;
            }

            List<CategoryEntity> categories = await serviceRepository.getCategories();
            page.categoryPicker.DisplayMemberPath = "Text";
            page.categoryPicker.SelectedValuePath = "Value";
            foreach (var category in categories)
            {
                page.categoryPicker.Items.Add(new { Text=category.Name, Value = category.Id});
            }
            page.categoryPicker.SelectedIndex = 0;

            page.buttonSubmit.Click += new Windows.UI.Xaml.RoutedEventHandler(async delegate (object o, RoutedEventArgs e)
            {
                page.buttonSubmit.IsEnabled = false;

                DateTimeOffset datumOd = page.DatumOd.Date;
                TimeSpan vrijemeOd = page.VrijemeOd.Time;

                DateTimeOffset datumDo = page.DatumDo.Date;
                TimeSpan vrijemeDo = page.VrijemeDo.Time;

                //create dto
                DateTime startTime = new DateTime(datumOd.Year, datumOd.Month, datumOd.Day, vrijemeOd.Hours, vrijemeOd.Minutes, vrijemeOd.Seconds);
                DateTime endTime = new DateTime(datumDo.Year, datumDo.Month, datumDo.Day, vrijemeDo.Hours, vrijemeDo.Minutes, vrijemeDo.Seconds);
                string content = page.contentTextbox.Text;
                int userId = SessionManager.SessionID;
                int categoryId = (int)page.categoryPicker.SelectedValue;
                string name = page.PlaceName.Text;
                double lon = parameter.lon;
                double lat = parameter.lat;

                int? result = null;

                if (place == null)
                {
                    InfoPlacePostDTO dto = new InfoPlacePostDTO()
                    {
                        startTime = startTime,
                        endTime = endTime,
                        content = content,
                        userId = userId,
                        categoryId = categoryId,
                        Name = name,
                        Longitude = lon,
                        Latitude = lat
                    };

                    result = await serviceRepository.addInfoWithPlace(dto);
                }
                else
                {
                    InfoPostDTO dto = new InfoPostDTO()
                    {
                        startTime = startTime,
                        endTime = endTime,
                        content = content,
                        userId = userId,
                        categoryId = categoryId,
                        placeId = place.Id
                    };

                    result = await serviceRepository.addInfo(dto);
                }

                if (result != null)
                {
                    page.Frame.Navigate(typeof(MapPage));
                }
                else
                    page.buttonSubmit.IsEnabled = true;
            });
        }
    }
}
