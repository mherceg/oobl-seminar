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
using System.Data.Entity.Spatial;

namespace Tracktor.WebService.Controllers
{
    public class PlaceController : ApiController
    {
        [Route("api/place/add")]
        [HttpPost]
        public int Add([FromBody]PlaceEntity place)
        {
            return 425;
        }

        [Route("api/place/update")]
        [HttpPut]
        public PlaceEntity Update([FromBody]PlaceEntity place)
        {            
            return new PlaceEntity()
            {
                Id = 52,
                Name = "Ozaljska 14",
                Location = new GeoCoordinate(45.8128451, 15.9753062)
            };
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
                //Location = DbGeography.FromText(string.Format("POINT({1} {0})", 45.8128451, 15.9753062)),
                Location = new GeoCoordinate(45.8128451, 15.9753062),
                Name = "Trg bana Jelačića"
            });
            places.Add(new PlaceEntity()
            {
                Id = 102,
                //Location = DbGeography.FromText(string.Format("POINT({1} {0})", 45.8118117, 15.9740687)),
                Location = new GeoCoordinate(45.8118117, 15.9740687),
                Name = "Gajeva 4"
            });
            places.Add(new PlaceEntity()
            {
                Id = 103,
                //Location = DbGeography.FromText(string.Format("POINT({1} {0})", 45.8123356, 15.9716064)),
                Location = new GeoCoordinate(45.8123356, 15.9716064),
                Name = "Cvjetni trg"
            });

            return places;
        }

    }
}