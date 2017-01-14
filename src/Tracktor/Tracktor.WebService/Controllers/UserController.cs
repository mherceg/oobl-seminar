using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tracktor.Business;
using Tracktor.Business.Interface;
using Tracktor.Domain;

namespace Tracktor.WebService.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/user/add")]
        [HttpPost]
        public int Add(UserEntity user)
        {
            try
            {
                IUserServices us = ServiceFactory.getUserServices();
                return us.Register(user);
            } catch (Exception)
            {
                return -1;
            }
        }

        [Route("api/user/get")]
        [HttpGet]
        public UserEntity Get(int id)
        {
            return new UserEntity()
            {
                FullName = "Mirko Fodor",
                Id = 12,
                IsActive = true,
                Username = "mirko.fodor@gmail.com",
                UserTypeId = 0
            };
        }

        [Route("api/user/update")]
        [HttpPut]
        public UserEntity Update(UserEntity user)
        {
            return new UserEntity()
            {
                FullName = "Mirko Fodor",
                Id = 12,
                IsActive = true,
                Username = "mirko.fodor@gmail.com",
                UserTypeId = 0
            };
        }

        [Route("api/user/list")]
        [HttpGet]
        public IEnumerable<UserEntity> List()
        {
            List<UserEntity> ret = new List<UserEntity>();
            ret.Add(new UserEntity()
            {
                FullName = "Mirko Fodor",
                Id = 12,
                IsActive = true,
                Username = "mirko.fodor@gmail.com",
                UserTypeId = 0
            });
            ret.Add(new UserEntity()
            {
                FullName = "Slavko Fodor",
                Id = 14,
                IsActive = true,
                Username = "slavko.fodor@gmail.com",
                UserTypeId = 0
            });

            return ret;
        }

        [Route("api/user/login")]
        [HttpPost]
        public int Login(LoginEntity le)
        {
            if (le.Username == "ayy")
                return 1;
            return -1;
        }



        //UseCase za usera - Dodavanje i Brisanje Favorite i Sponsorship mjesta
        [Route("api/user/addfavorite")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult AddFavorite([FromBody]int userId, [FromBody]int placeId)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    //IPlaceServices userService = ServiceFactory.getUserServices();
                    //success = return userService.AddFavouritePlace(userId, placeId);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            return Ok(success);
        }

        [Route("api/user/addsponsorship")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult AddSponsorship([FromBody]int userId, [FromBody]int placeId)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    //IPlaceServices userService = ServiceFactory.getUserServices();
                    //success = return userService.AddSponsorshipPlace(userId, placeId);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            return Ok(success);
        }

        [Route("api/user/rmfavorite")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult RmFavorite([FromBody]int userId, [FromBody]int placeId)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    //IPlaceServices userService = ServiceFactory.getUserServices();
                    //success = return userService.RemoveFavouritePlace(userId, placeId);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            return Ok(success);
        }

        [Route("api/user/rmsponsorship")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult RmSponsorship([FromBody]int userId, [FromBody]int placeId)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    //IPlaceServices userService = ServiceFactory.getUserServices();
                    //success = return userService.RemoveSponsorshipPlace(userId, placeId);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            return Ok(success);
        }
    }
}
