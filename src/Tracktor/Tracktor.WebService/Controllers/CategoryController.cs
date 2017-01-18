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
    public class CategoryController : ApiController
    {
        //Potrebno pri pokretanju mobilne app da ne bude hardkodirano
        [Route("api/category/list")]
        [HttpGet]
        [ResponseType(typeof(IEnumerable<CategoryEntity>))]
        public IHttpActionResult List()
        {
            List<CategoryEntity> categories = new List<CategoryEntity>();

            try
            {
                ICategoryServices categoryService = ServiceFactory.getCategoryServices();
                categories = categoryService.ListAll();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok(categories);
        }

    }
}
