﻿using System;
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

namespace Tracktor.Mobile
{
    class InformationListPageController
    {
        private InformationListPage page = null;  

        public InformationListPageController(InformationListPage page)
        {
            this.page = page;            
        }
        public async Task InitInformations(PlaceEntity place)
        {
            ServiceRepository serviceRepository = new ServiceRepository();

            IEnumerable<InfoDTO> informations = await serviceRepository.getInfoDTO(place);

            foreach (var information in informations)
            {
                page.InformationListbox.Items.Add(
                new TextBlock()
                {
                    Text = information.content,
                    Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                    FontSize = 22
                }
            );
            }           
        }
    }
}
