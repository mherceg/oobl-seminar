using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tracktor.Business;
using Tracktor.Domain;
using Tracktor.Web.ViewModels.Event;
using Tracktor.Web.ViewModels.User;

namespace Tracktor.Web.Controllers
{
    public class EventController : Controller
    {
        //GET: Search
        public ActionResult Search(int meh = 0)
        {
            var vm = new SearchVM
            {
                Places = getSearchPlaces(meh),
                Categories = getHtmlCategories(),
            };

            return View(vm);
        }

        private List<PlaceEntity> getSearchPlaces(int meh)
        {
            var placeService = ServiceFactory.getPlaceServices();
            if (meh == 0)
            {
                return placeService.GetByFilter(getDefaultSearchFilters(), true, true);
            }
            else if (meh == 1)
            {
                return placeService.GetFavorite((Session["user"] as UserEntity).Id);
            }
            return placeService.GetSponsorship((Session["user"] as UserEntity).Id);
        }

        private IDictionary<string, bool> getDefaultSearchFilters()
        {
            var categoryService = ServiceFactory.getCategoryServices();
            var categories = categoryService.ListAll();
            var rv = new Dictionary<string, bool>();
            foreach (var c in categories)
            {
                rv[c.Name] = true;
            }
            return rv;
        }

        private List<SelectListItem> getHtmlCategories()
        {
            var categoryService = ServiceFactory.getCategoryServices();
            var categories = categoryService.ListAll();
            var rv = new List<SelectListItem>();
            foreach (var c in categories)
            {
                rv.Add(new SelectListItem
                {
                    Selected = false,
                    Text = c.Name,
                    Value = c.Id.ToString(),
                });
            }
            return rv;
        }

        [HttpPost]
        public ActionResult Search(SearchVM vm)
        {
            var filters = getSearchFIlters(vm.Categories);

            var infoService = ServiceFactory.getInfoServices();
            vm.Results = infoService.GetByFilter(filters, true, true, vm.PlaceId);

            return View(vm);
        }

        private IDictionary<string, bool> getSearchFIlters(List<SelectListItem> categories)
        {
            var rv = new Dictionary<string, bool>();
            bool anySelected = false;
            foreach (var c in categories)
            {
                rv[c.Text] = c.Selected;
                if (c.Selected) { anySelected = true; }
            }
            if (!anySelected)
            {
                var r = new Dictionary<string, bool>();
                foreach (var k in rv.Keys)
                {
                    r[k] = true;
                }
                rv = r;
            }
            return rv;
        }


        public ActionResult InfoDetails(int id, int placeId)
        {
            var info = getInfoEntity(id, placeId);
            var vm = new InfoVM
            {
                Id = id,
                Category = info.category.Name,
                Content = info.content,
                FromUser = info.user.FullName,
                EndTime = info.endTime,
                Time = info.time,
                Lat = info.place.Location.Latitude,
                Lng = info.place.Location.Longitude,
                PlaceId = info.placeId,
                PlaceName = info.place.Name,
                Reputation = info.GetReputation(),
                Comments = getInfoComments(info),
            };

            return View(vm);
        }

        private InfoEntity getInfoEntity(int id, int placeId)
        {
            var infoService = ServiceFactory.getInfoServices();
            var placeInfos = infoService.GetByPlace(placeId);
            return placeInfos.Find(i => i.Id == id);
        }

        private List<InfoVM.Comment> getInfoComments(InfoEntity e)
        {
            var rv = new List<InfoVM.Comment>();
            foreach (var c in e.comments)
            {
                rv.Add(new InfoVM.Comment
                {
                    Id = c.Id,
                    Username = c.user.FullName,
                    Content = c.Content,
                    Reputation = c.GetReputation(),
                });
            }

            return rv;
        }

        public ActionResult Rate(int id, int placeId, int value)
        {
            var rie = new ReputationInfoEntity
            {
                Score = value == 1 ? true : false,
                ContentCommentId = id,
                UserId = (Session["user"] as UserEntity).Id
            };

            try
            {
                var infoService = ServiceFactory.getInfoServices();
                infoService.Rate(rie);
            }
            catch (Exception e)
            {
                ;
            }
            return RedirectToAction(nameof(InfoDetails), new { id = id, placeId = placeId });
        }

        public ActionResult RateComment(int id, int infoId, int placeId, int value)
        {
            var rce = new ReputationCommentEntity
            {
                Score = value == 1 ? true : false,
                ContentCommentId = id,
                UserId = (Session["user"] as UserEntity).Id
            };

            try
            {
                var commentService = ServiceFactory.getCommentServices();
                commentService.Rate(rce);
            }
            catch (Exception e)
            {
                ;
            }
            return RedirectToAction(nameof(InfoDetails), new { id = infoId, placeId = placeId });
        }

        [HttpPost]
        public ActionResult AddComment(int infoId, int placeId, string comment)
        {
            var ce = new CommentEntity
            {
                EndTime = DateTime.Now,
                Content = comment,
                ContentInfoId = infoId,
                UserId = (Session["user"] as UserEntity).Id,
            };

            var commentServices = ServiceFactory.getCommentServices();
            commentServices.Add(ce);

            return RedirectToAction(nameof(InfoDetails), new { id = infoId, placeId = placeId });
        }

        public ActionResult AddInfo(int meh = 0)
        {
            var vm = new AddInfoVM
            {
                SelectedCategoryId = 0,
                Categories = getHtmlCategories(),
                Places = getPlacesForAddInfo(meh),
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddInfo(AddInfoVM vm)
        {
            var ie = new InfoEntity
            {
                categoryId = vm.SelectedCategoryId,
                content = vm.Content,
                time = vm.StartTime,
                endTime = vm.EndTime,
                userId = (Session["user"] as UserEntity).Id,
                placeId = vm.PlaceId,
            };
            var infoService = ServiceFactory.getInfoServices();
            var id = infoService.NewInfo(ie);

            return RedirectToAction(nameof(InfoDetails), new { id = id, placeId = vm.PlaceId });
        }

        private List<PlaceEntity> getPlacesForAddInfo(int meh)
        {
            if(meh == 1 || meh == 2)
            {
                return getSearchPlaces(meh);
            }
            return ServiceFactory.getPlaceServices().GetAll();
        }
    }
}