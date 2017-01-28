using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Mobile.Pages;
using Tracktor.WebService.Models;
using Windows.UI.Xaml.Input;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

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
            ServiceRepository serviceRepository = new ServiceRepository();

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

            page.commentButton.Click += new RoutedEventHandler(async delegate (object o, RoutedEventArgs e)
            {
                page.commentButton.IsEnabled = false;
                page.commentTextbox.IsEnabled = false;

                CommentPostDTO comment = new CommentPostDTO()
                {
                    userId = SessionManager.SessionID,
                    content = page.commentTextbox.Text,
                    contentInfoId = info.Id,
                    time = DateTime.Now
                };

                int? id = await serviceRepository.setComment(comment);

                if (id != null)
                {
                    List<CommentDTO> tempList = new List<CommentDTO>(info.comments);
                    tempList.Add(new CommentDTO()
                    {
                        Id = (int)id,
                        content = comment.content,
                        user = "Ja",
                        reputation = 0,
                        time = comment.time
                    });
                    info.comments = tempList;
                }

                InitComments(info);

                page.commentButton.IsEnabled = true;
                page.commentTextbox.IsEnabled = true;
            }
            );

            InitComments(info);
        }

        private void InitComments(InfoDTO info)
        {
            page.CommentListbox.Items.Clear();

            var comments = info.comments.Reverse();

            //comments 
            foreach (var comment in comments)
            {
                StackPanel commentPanel = new StackPanel()
                {
                    Orientation = Orientation.Horizontal
                };

                StackPanel votePanel = new StackPanel()
                {
                    Orientation = Orientation.Vertical
                };

                StackPanel commentTextPanel = new StackPanel()
                {
                    Orientation = Orientation.Vertical
                };

                commentPanel.Children.Add(votePanel);
                commentPanel.Children.Add(commentTextPanel);

                TextBlock scoreText = new TextBlock()
                {
                    Text = comment.reputation.ToString(),
                    Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                    TextAlignment = Windows.UI.Xaml.TextAlignment.Center,
                    FontSize = 18
                };

                votePanel.Children.Add(scoreText);

                TextBlock posterName = new TextBlock()
                {
                    Text = comment.user,
                    Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                    FontSize = 18
                };

                TextBlock commentText = new TextBlock()
                {
                    Text = comment.content,
                    Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                    FontSize = 22
                };

                commentTextPanel.Children.Add(posterName);
                commentTextPanel.Children.Add(commentText);

                page.CommentListbox.Items.Add(commentPanel);
            }
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
