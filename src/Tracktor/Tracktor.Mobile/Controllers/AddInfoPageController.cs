using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Mobile.Pages;
using Tracktor.Domain;

namespace Tracktor.Mobile.Controllers
{
    class AddInfoPageController
    {
        private AddInfoPage page = null;
        public AddInfoPageController(AddInfoPage page)
        {
            this.page = page;            
        }

        public void Init(PlaceEntity place)
        {
            if (place == null)
            {
                page.PlaceName.IsEnabled = true;
                page.sponsorCheckbox.IsEnabled = true;
            }
        }
    }
}
