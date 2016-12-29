using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tracktor.Domain;

namespace Tracktor.WebService.Controllers
{
    public class InfoController : ApiController
    {
        public bool Delete(int id)
        {
            return true;
        }

        public InfoEntity Get(int id)
        {
            var ie = new InfoEntity()
            {
                Id = id,
                //PlaceId = 7,
                //UserId = 7
            };
            return ie;
        }

        public IEnumerable<PlaceEntity> List()
        {
            return null;
        }

    }
}
