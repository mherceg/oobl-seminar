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
    public class UserTypeController : ApiController
    {
        [Route("api/usertype/list")]
        [HttpGet]
        [ResponseType(typeof(IEnumerable<UserTypeEntity>))]
        public IHttpActionResult List()
        {
            List<UserTypeEntity> userTypes = new List<UserTypeEntity>();

            try
            {
                IUserTypeServices categoryService = ServiceFactory.getUserTypeServices();
                userTypes = categoryService.ListAll();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok(userTypes);
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