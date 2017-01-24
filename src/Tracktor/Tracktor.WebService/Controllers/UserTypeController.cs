using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tracktor.Business;
using Tracktor.Business.Interface;
using Tracktor.Domain;

namespace Tracktor.WebService.Controllers
{
    public class UserTypeController : ApiController
    {
        [Route("api/usertype/list")]
        [HttpGet]
        public IEnumerable<UserTypeEntity> List()
        {
            List<UserTypeEntity> userTypes = new List<UserTypeEntity>();
            userTypes.Add(new UserTypeEntity()
            {
                Id = 101,
                Type = "User"
            });
            userTypes.Add(new UserTypeEntity()
            {
                Id = 102,
                Type = "VipUser"
            });
            userTypes.Add(new UserTypeEntity()
            {
                Id = 103,
                Type = "Admin"
            });

            return userTypes;
        }



        #region Ne koristi se u use caseovima za mobilnu
        //[Route("api/usertype/add")]
        //[HttpPost]
        //public int Add([FromBody]UserTypeEntity userType)
        //{
        //    return 17;
        //}

        //[Route("api/usertype/update")]
        //[HttpPatch]
        //public UserTypeEntity Update([FromBody]UserTypeEntity userType)
        //{
        //    return userType;
        //}

        //[Route("api/usertype/delete")]
        //[HttpDelete]
        //public bool Delete(int id)
        //{
        //    return true;
        //}
        #endregion

    }
}