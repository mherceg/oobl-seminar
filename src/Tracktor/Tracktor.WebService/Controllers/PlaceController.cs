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

        //Implementirano: AddNew, ListFilter, ListFavorite, ListSponsorship
        //Treba provjeriti: sve
        //Fali:

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
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
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
                try
                {
                    IPlaceServices placeService = ServiceFactory.getPlaceServices();
                    places = placeService.GetByFilter(filters, active, future);
                    if (places.Count == 0)
                    {
                        return Ok("Za zadane uvjete pretrage nema događaja!");
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
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
                try
                {
                    IPlaceServices placeService = ServiceFactory.getPlaceServices();
                    places = placeService.GetFavorite(userId);
                    if (places.Count == 0)
                    {
                        return Ok("Korisnik nema najdražih mjesta!");
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
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
                try
                {
                    IPlaceServices placeService = ServiceFactory.getPlaceServices();
                    places = placeService.GetSponsorship(userId);
                    if (places.Count == 0)
                    {
                        return Ok("Korisnik nema sponzoriranih mjesta!");
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
            }

            return Ok(places);
        }

        [Route("api/place/all")]
        [HttpGet]
        [ResponseType(typeof(IEnumerable<PlaceEntity>))]
        public IHttpActionResult ListAll()
        {
            List<PlaceEntity> places = new List<PlaceEntity>();
            if (ModelState.IsValid)
            {
                try
                {
                    IPlaceServices placeService = ServiceFactory.getPlaceServices();
                    places = placeService.GetAll();
                }
                catch (Exception)
                {
                    return BadRequest("Neispravni podaci");
                }
            }
            else
            {
                return BadRequest("Neispravni podaci");
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