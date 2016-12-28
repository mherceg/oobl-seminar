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
    public class PlaceController : ApiController
    {
        [Route("api/place/add")]
        [HttpPost]
        public int Add([FromBody]PlaceEntity place)
        {
            return place.Id;
        }

        [Route("api/place/update")]
        [HttpPatch]
        public PlaceEntity Update([FromBody]PlaceEntity place)
        {
            return place;
        }

        [Route("api/place/delete")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return true;
        }

        [Route("api/place/list")]
        [HttpGet]
        public IEnumerable<PlaceEntity> List()
        {
            List<PlaceEntity> places = new List<PlaceEntity>();
            places.Add(new PlaceEntity()
            {
                Id = 101,
                Location = null,
                Name = "Trg bana Jelačića"
            });
            places.Add(new PlaceEntity()
            {
                Id = 102,
                Location = null,
                Name = "Gajeva 4"
            });
            places.Add(new PlaceEntity()
            {
                Id = 103,
                Location = null,
                Name = "Cvjetni trg"
            });

            return places;
        }

    }
}