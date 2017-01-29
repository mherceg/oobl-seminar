using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Domain;
using Tracktor.WebService.Models;
using Windows.UI.Xaml;

namespace Tracktor.Mobile
{
    class LoginPageController
    {
        private LoginPage page = null;

        public LoginPageController(LoginPage page)
        {
            this.page = page;
        }

        public async void LoginClick()
        {            
            page.UsernameTextbox.IsEnabled = false;
            page.PasswordTextbox.IsEnabled = false;
            page.LoginButton.IsEnabled = false;

            LoginEntity le = new LoginEntity()
            {
                Username = page.UsernameTextbox.Text,
                Password = page.PasswordTextbox.Password
            };

            ServiceRepository service = new ServiceRepository();
            int sessionId = await service.getSessionId(le);
            if (sessionId < 0)
            {
                page.LoginButton.IsEnabled = true;
                page.UsernameTextbox.IsEnabled = true;
                page.PasswordTextbox.IsEnabled = true;
                page.InvalidLoginLabel.Visibility = Visibility.Visible;
                return;
            }

            UserDTO userDTO = await service.getUser(sessionId);

            SessionManager.BeginSession(userDTO);

            page.Frame.Navigate(typeof(MapPage));   
        }
    }
}
