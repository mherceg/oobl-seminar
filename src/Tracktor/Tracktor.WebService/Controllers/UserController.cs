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

        public IEnumerable<UserEntity> List()
        {
            List<UserEntity> ret = new List<UserEntity>();
            ret.Add(new UserEntity()
            {
                FullName = "Mirko Fodor",
                Id = 12,
                IsActive = 0,
                Username = "mirko.fodor@gmail.com",
                UserTypeId = 0
            });
            ret.Add(new UserEntity()
            {
                FullName = "Slavko Fodor",
                Id = 14,
                IsActive = 0,
                Username = "slavko.fodor@gmail.com",
                UserTypeId = 0
            });

            return ret;
        }

        public int Login(LoginEntity le)
        {
            return 7;
        }
    }
}
