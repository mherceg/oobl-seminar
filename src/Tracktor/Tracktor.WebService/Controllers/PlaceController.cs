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
using System.Web.Http.Description;
using Tracktor.WebService.Models;

namespace Tracktor.WebService.Controllers
{
    public class PlaceController : ApiController
    {
        //Add metode - Unos novog mjesta
        [Route("api/place/add")]
        [HttpPost]
        [ResponseType(typeof(int))]
        public IHttpActionResult AddNew([FromBody]PlaceEntity place)
        {
            int Id = 0;
            if (ModelState.IsValid)
            {

                try
                {
                    IPlaceServices placeService = ServiceFactory.getPlaceServices();
                    Id = placeService.Add(place);
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            return Ok(Id);
        }


        //List metode - Dohvat filtriranih, najdrazih i sponsorship mjesta
        [Route("api/place/filter")]
        [HttpPost]
        [ResponseType(typeof(IEnumerable<PlaceEntity>))]
        public IHttpActionResult ListFilter([FromBody]IDictionary<string, bool> filters, [FromUri]bool active, [FromUri]bool future)
        {
            List<PlaceEntity> places = new List<PlaceEntity>();
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    //IPlaceServices placeService = ServiceFactory.getPlaceServices();
                    //var mjesta = placeService.GetByFilter(filters, active, future);

                    //Mock
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

                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }

            return Ok(places);
        }

        [Route("api/place/favorite")]
        [HttpGet]
        [ResponseType(typeof(IEnumerable<PlaceEntity>))]
        public IHttpActionResult ListFavorite([FromUri]int userId)
        {
            List<PlaceEntity> places = new List<PlaceEntity>();
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    IPlaceServices placeService = ServiceFactory.getPlaceServices();
                    places = placeService.GetFavorite(userId);

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

                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }

            return Ok(places);
        }

        [Route("api/place/sponsorship")]
        [HttpGet]
        [ResponseType(typeof(IEnumerable<PlaceEntity>))]
        public IHttpActionResult ListSponsorship([FromUri]int userId)
        {
            List<PlaceEntity> places = new List<PlaceEntity>();
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    //IPlaceServices placeService = ServiceFactory.getPlaceServices();
                    //places = placeService.GetSponsorship(userId);

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

                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }

            return Ok(places);
        }


        #region Ne koristi se u use caseovima
        //[Route("api/place/update")]
        //[HttpPut]
        //public PlaceEntity Update([FromBody]PlaceEntity place)
        //{            
        //    return new PlaceEntity()
        //    {
        //        Id = 52,
        //        Name = "Ozaljska 14",
        //        Location = new GeoCoordinate(45.8128451, 15.9753062)
        //    };
        //}

        //[Route("api/place/delete")]
        //[HttpDelete]
        //public bool Delete(int id)
        //{
        //    return true;
        //}
        #endregion


    }
}