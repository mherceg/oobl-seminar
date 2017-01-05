using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
    }
}
