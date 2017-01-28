using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Mobile.Pages;
using Tracktor.WebService.Models;
using Windows.UI.Xaml.Input;

namespace Tracktor.Mobile.Controllers
{
    class InformationPageController
    {
        private InformationPage page = null;

        public InformationPageController(InformationPage page)
        {
            this.page = page;
        }
        public async Task InitInformation(InfoDTO info)
        {
            page.vrijemeOd.Text = "Od: " + info.startTime.ToString();
            page.vrijemeDo.Text = "Do: " + info.endTime.ToString();

            page.opis.Text = info.content;

            page.likesCount.Text = info.reputation.ToString();

            page.upvote.Tapped += new TappedEventHandler(async delegate(object o, TappedRoutedEventArgs e)
                {
                    await Vote(true, info);
                }
            );

            page.downvote.Tapped += new TappedEventHandler(async delegate (object o, TappedRoutedEventArgs e)
            {
                await Vote(false, info);
            }
            );
        }

        private async Task Vote(bool up, InfoDTO info)
        {
            ServiceRepository serviceRepository = new ServiceRepository();

            page.upvote.IsTapEnabled = false;
            page.downvote.IsTapEnabled = false;
            page.upvote.Opacity = 0.4;
            page.downvote.Opacity = 0.4;

            RateInfoPostDTO rip = new RateInfoPostDTO()
            {
                infoId = info.Id,
                userId = SessionManager.SessionID,
                score = up
            };

            bool result = await serviceRepository.setVoteInfo(rip);

            if (result)
            {
                int factor = 1;
                if (!up)
                    factor = -1;
                page.likesCount.Text = (int.Parse(page.likesCount.Text) + factor).ToString();
            }

            page.upvote.IsTapEnabled = true;
            page.downvote.IsTapEnabled = true;
            page.upvote.Opacity = 1;
            page.downvote.Opacity = 1;
        }
    }
}
