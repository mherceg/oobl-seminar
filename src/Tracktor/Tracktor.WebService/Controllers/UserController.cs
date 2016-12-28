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
    }
}
