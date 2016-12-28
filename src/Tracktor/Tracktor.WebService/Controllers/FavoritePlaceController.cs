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
    public class FavoritePlaceController : ApiController
    {
        [Route("api/favoriteplace/add")]
        [HttpPost]
        public int Add([FromBody]FavoritePlaceEntity favPlace)
        {
            return favPlace.Id;
        }

        [Route("api/favoritplace/delete")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return true;
        }
    }
}