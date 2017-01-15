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
using Tracktor.WebService.Models;

namespace Tracktor.WebService.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/user/add")]
        [HttpPost]
        [ResponseType(typeof(int))]
        public IHttpActionResult Add(UserEntity user)
        {
            int id = 0;
            if(ModelState.IsValid)
            {
                try
                {
                    IUserServices userService = ServiceFactory.getUserServices();
                    id = userService.Register(user);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
            }

            return Ok(id);
        }

        [Route("api/user/login")]
        [HttpPost]
        [ResponseType(typeof(int))]
        public IHttpActionResult Login(LoginEntity le)
        {
            //Vraca id korisnika?
            int id = 0;
            if (ModelState.IsValid)
            {
                try
                {
                    IUserServices userService = ServiceFactory.getUserServices();
                    id = userService.Login(le);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
            }

            return Ok(id);
        }

        [Route("api/user/get")]
        [HttpGet]
        [ResponseType(typeof(UserDTO))]
        public IHttpActionResult Get([FromUri]int id)
        {
            UserDTO user = new UserDTO();
            if (ModelState.IsValid)
            {
                try
                {
                    IUserServices userService = ServiceFactory.getUserServices();
                    var a = userService.Get(id);
                    //user = WebMapper(userService.Get(id));
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
            }

            //return Ok(user);

            return Ok(new UserDTO()
            {
                FullName = "Mirko Fodor",
                Id = 12,
                IsActive = true,
                UserTypeId = 0
            });
        }



        //UseCase za usera - Dodavanje i Brisanje Favorite i Sponsorship mjesta
        [Route("api/user/addFavorite")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult AddFavorite(int userId, int placeId)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                try
                {
                    IUserServices userService = ServiceFactory.getUserServices();
                    success = userService.AddFavouritePlace(userId, placeId);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
            }

            return Ok(success);
        }

        [Route("api/user/addSponsor")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult AddSponsor(int userId, int placeId)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                try
                {
                    IUserServices userService = ServiceFactory.getUserServices();
                    success = userService.AddSponsorPlace(userId, placeId);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
            }

            return Ok(success);
        }

        [Route("api/user/rmFavorite")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult RmFavorite(int userId, int placeId)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                try
                {
                    IUserServices userService = ServiceFactory.getUserServices();
                    success = userService.RemoveFavouritePlace(userId, placeId);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
            }

            return Ok(success);
        }

        [Route("api/user/rmSponsor")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult RmSponsor(int userId, int placeId)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                try
                {
                    IUserServices userService = ServiceFactory.getUserServices();
                    success = userService.RemoveSponsorPlace(userId, placeId);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
            }

            return Ok(success);
        }



        #region Ne koristi se u use caseovima za mobilnu

        //[Route("api/user/update")]
        //[HttpPut]
        //public UserEntity Update(UserEntity user)
        //{
        //    return new UserEntity()
        //    {
        //        FullName = "Mirko Fodor",
        //        Id = 12,
        //        IsActive = true,
        //        Username = "mirko.fodor@gmail.com",
        //        UserTypeId = 0
        //    };
        //}

        //[Route("api/user/list")]
        //[HttpGet]
        //public IEnumerable<UserEntity> List()
        //{
        //    List<UserEntity> ret = new List<UserEntity>();
        //    ret.Add(new UserEntity()
        //    {
        //        FullName = "Mirko Fodor",
        //        Id = 12,
        //        IsActive = true,
        //        Username = "mirko.fodor@gmail.com",
        //        UserTypeId = 0
        //    });
        //    ret.Add(new UserEntity()
        //    {
        //        FullName = "Slavko Fodor",
        //        Id = 14,
        //        IsActive = true,
        //        Username = "slavko.fodor@gmail.com",
        //        UserTypeId = 0
        //    });

        //    return ret;
        //}

        #endregion


    }
}
