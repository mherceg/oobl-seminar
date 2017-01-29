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

namespace Tracktor.Mobile
{
    class FiltersPageController
    {
        private FiltersPage page = null;

        private Dictionary<string, bool> categoryToggled = new Dictionary<string, bool>();
        private Dictionary<string, bool> timeToggled = new Dictionary<string, bool>();

        

        public FiltersPageController(FiltersPage page)
        {
            this.page = page;

            
        }
        public async Task InitCategories()
        {
            ServiceRepository serviceRepository = new ServiceRepository();

            List<CategoryEntity> categories = await serviceRepository.getCategories();

            page.FiltersListBox.Items.Add(
                new TextBlock()
                {
                    Text = "Kategorije",
                    Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                    FontSize = 20
                }
            );

            foreach(var category in categories)
            {
                categoryToggled[category.Name] = true;
                ToggleSwitch s = new ToggleSwitch()
                {
                    Name = category.Name,
                    Header = category.Name,
                    IsOn = true,
                    Width = 300
                };
                s.Toggled += new RoutedEventHandler(delegate (object o, RoutedEventArgs a)
                {
                    categoryToggled[category.Name] = !categoryToggled[category.Name];
                });
                page.FiltersListBox.Items.Add(s);
            }

            page.FiltersListBox.Items.Add(
                new TextBlock()
                {
                    Text = "Vrijeme",
                    Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                    FontSize = 20
                }
            );

            //current
            timeToggled["current"] = true;
            ToggleSwitch currentSwitch = new ToggleSwitch()
            {
                Name = "current",
                Header = "Trenutni",
                IsOn = true,
                Width = 300
            };
            currentSwitch.Toggled += new RoutedEventHandler(delegate (object o, RoutedEventArgs a)
            {
                timeToggled["current"] = !timeToggled["current"];
            });
            page.FiltersListBox.Items.Add(currentSwitch);

            //current
            timeToggled["future"] = true;
            ToggleSwitch futureSwitch = new ToggleSwitch()
            {
                Name = "future",
                Header = "Budući",
                IsOn = true,
                Width = 300
            };
            futureSwitch.Toggled += new RoutedEventHandler(delegate (object o, RoutedEventArgs a)
            {
                timeToggled["future"] = !timeToggled["future"];
            });
            page.FiltersListBox.Items.Add(futureSwitch);
        }

        public void ApplyFilters()
        {
            CategoriesContainer container = new CategoriesContainer()
            {
                categories = categoryToggled,
                time = timeToggled
            };
            page.Frame.Navigate(typeof(MapPage), container);
        }
    }
}
