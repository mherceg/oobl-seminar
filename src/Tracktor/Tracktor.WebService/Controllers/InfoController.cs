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
using Tracktor.WebService.Models;

namespace Tracktor.WebService.Controllers
{
    public class InfoController : ApiController
    {
        private DTOAssembler _DTOAssempler { get; set; }
        public InfoController()
        {
            _DTOAssempler = new DTOAssembler();
        }

        //Dodavanje novog dogadjaja s postojecim mjestom
        [Route("api/info/add")]
        [HttpPost]
        [ResponseType(typeof(int))]
        public IHttpActionResult Add([FromBody]InfoPostDTO info)
        {
            int id = 0;
            if (ModelState.IsValid)
            {
                try
                {
                    InfoEntity infoDomain = _DTOAssempler.CreateInfoEntity(info);
                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    id = infoService.NewInfo(infoDomain);
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

            return Ok(id);
        }

        [Route("api/info/addWplace")]
        [HttpPost]
        [ResponseType(typeof(int))]
        public IHttpActionResult AddWithPlace([FromBody]InfoPlacePostDTO info)
        {
            int id = 0;
            if (ModelState.IsValid)
            {
                try
                {
                    PlaceEntity placeDomain = _DTOAssempler.CreatePlaceEntity(info);
                    InfoEntity infoDomain = _DTOAssempler.CreateInfoEntity(info);

                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    id = infoService.NewInfo(infoDomain, placeDomain);
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

            return Ok(id);
        }


        //List metode - Dohvat filtriranih dogadjaja za odredjeno mjesto, dohvat svih dogadjaja za odredjeno mjesto
        [Route("api/info/ListByFilter")]
        [HttpPost]
        [ResponseType(typeof(IEnumerable<InfoDTO>))]
        public IHttpActionResult ListByFilter([FromBody]IDictionary<string, bool> filters, [FromUri]bool active, [FromUri]bool future, [FromUri]int PlaceId)
        {
            List<InfoDTO> events = new List<InfoDTO>();
            if (ModelState.IsValid)
            {
                try
                {
                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    var infoDomain = infoService.GetByFilter(filters, active, future, PlaceId);

                    foreach(var info in infoDomain)
                    {
                        events.Add(_DTOAssempler.CreateInfoDTO(info));
                    }
                    if (infoDomain.Count == 0)
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

            return Ok(events);
        }

        [Route("api/info/ListByPlace")]
        [HttpGet]
        [ResponseType(typeof(IEnumerable<InfoDTO>))]
        public IHttpActionResult ListByPlace([FromUri]int PlaceId)
        {
            List<InfoDTO> events = new List<InfoDTO>();
            if (ModelState.IsValid)
            {
                try
                {
                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    var infoDomain = infoService.GetByPlace(PlaceId);

                    foreach (var info in infoDomain)
                    {
                        events.Add(_DTOAssempler.CreateInfoDTO(info));
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

            return Ok(events);
        }


        //Ocjenjivanje dogadjaja
        [Route("api/info/rate")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult Rate(RateInfoPostDTO reputationInfo)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                try
                {
                    ReputationInfoEntity repInfoDomain = _DTOAssempler.CreateReputationInfoEntity(reputationInfo);
                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    success = infoService.Rate(repInfoDomain);
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

            return Ok(success);
        }






        #region Ne koristi se u use caseovima za mobilnu

        //Nikad ne dohvacamo sve dogadjaje bez filtera

        //[Route("api/info/list")]
        //[HttpGet]
        //public IEnumerable<InfoEntity> List()
        //{
        //    List<InfoEntity> infoList = new List<InfoEntity>();

        //    //Prvi info
        //    List<CommentEntity> commentsMock1 = new List<CommentEntity>();
        //    commentsMock1.Add(new CommentEntity()
        //    {
        //        Id = 101,
        //        EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
        //        UserId = 10,
        //        ContentInfoId = 52,
        //        Content = "Odlicna atmosfera!!! =))"
        //    });
        //    commentsMock1.Add(new CommentEntity()
        //    {
        //        Id = 102,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
        //        UserId = 11,
        //        ContentInfoId = 52,
        //        Content = "Katastrofa..."
        //    });
        //    commentsMock1.Add(new CommentEntity()
        //    {
        //        Id = 103,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:34:32.17"),
        //        UserId = 10,
        //        ContentInfoId = 52,
        //        Content = "Ma sto katastrofa? o.O"
        //    });
        //    commentsMock1.Add(new CommentEntity()
        //    {
        //        Id = 104,
        //        EndTime = Convert.ToDateTime("2016/12/26 14:22:08.07"),
        //        UserId = 12,
        //        ContentInfoId = 52,
        //        Content = "Bilo je ok!"
        //    });

        //    infoList.Add(new InfoEntity()
        //    {
        //        Id = 52,
        //        time = DateTime.Now,
        //        category = new CategoryEntity() { Id = 1, Name = "Koncert" },
        //        user = new UserEntity() { Id = 2, Username = "KorIme", Password = "123", FullName = "Marko Marić", IsActive = true, UserTypeId = 1 },
        //        place = new PlaceEntity() { Id = 102, Location = new GeoCoordinate(45.8118117, 15.9740687), Name = "Gajeva 4" },
        //        content = "Koncert za humaniratnu akciju 'Želim život'",
        //        endTime = DateTime.Now.AddDays(4.7),
        //        comments = commentsMock1
        //    });

        //    //Drugi info
        //    List<CommentEntity> commentsMock2 = new List<CommentEntity>();
        //    commentsMock2.Add(new CommentEntity()
        //    {
        //        Id = 201,
        //        EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
        //        UserId = 10,
        //        ContentInfoId = 52,
        //        Content = "Strava =))"
        //    });
        //    commentsMock2.Add(new CommentEntity()
        //    {
        //        Id = 202,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
        //        UserId = 11,
        //        ContentInfoId = 52,
        //        Content = "Super"
        //    });


        //    infoList.Add(new InfoEntity()
        //    {
        //        Id = 52,
        //        time = DateTime.Now,
        //        category = new CategoryEntity() { Id = 1, Name = "Sportski događaj" },
        //        user = new UserEntity() { Id = 2, Username = "KorIme", Password = "123", FullName = "Marko Marić", IsActive = true, UserTypeId = 1 },
        //        place = new PlaceEntity() { Id = 102, Location = new GeoCoordinate(45.8123356, 15.9716064), Name = "Cvjetni trg" },
        //        content = "Izvlaćenje startnih brojeva za Snježnu kraljicu",
        //        endTime = DateTime.Now.AddDays(4.7),
        //        comments = commentsMock2
        //    });

        //    return infoList;
        //}



        //Nikad ne dohvacamo neki specificni dogadjaj po IDu

        //[Route("api/info/get")]
        //[HttpGet]
        //public InfoEntity Get(int id)
        //{
        //    List<CommentEntity> commentsMock = new List<CommentEntity>();
        //    commentsMock.Add(new CommentEntity()
        //    {
        //        Id = 101,
        //        EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
        //        UserId = 10,
        //        ContentInfoId = 52,
        //        Content = "Odlicna atmosfera!!! =))"
        //    });
        //    commentsMock.Add(new CommentEntity()
        //    {
        //        Id = 102,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
        //        UserId = 11,
        //        ContentInfoId = 52,
        //        Content = "Katastrofa..."
        //    });
        //    commentsMock.Add(new CommentEntity()
        //    {
        //        Id = 103,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:34:32.17"),
        //        UserId = 10,
        //        ContentInfoId = 52,
        //        Content = "Ma sto katastrofa? o.O"
        //    });
        //    commentsMock.Add(new CommentEntity()
        //    {
        //        Id = 104,
        //        EndTime = Convert.ToDateTime("2016/12/26 14:22:08.07"),
        //        UserId = 12,
        //        ContentInfoId = 52,
        //        Content = "Bilo je ok!"
        //    });

        //    return new InfoEntity()
        //    {
        //        Id = 52,
        //        time = DateTime.Now,
        //        category = new CategoryEntity() { Id = 1, Name = "Koncert" },
        //        user = new UserEntity() { Id = 2, Username = "KorIme", Password = "123", FullName = "Marko Marić", IsActive = true, UserTypeId = 1 },
        //        place = new PlaceEntity() { Id = 102, Location = new GeoCoordinate(45.8118117, 15.9740687), Name = "Gajeva 4" },
        //        content = "Koncert za humaniratnu akciju 'Želim život'",
        //        endTime = DateTime.Now.AddDays(4.7),
        //        comments = commentsMock
        //    };
        //}


        //[Route("api/info/update")]
        //[HttpPut]
        //public InfoEntity Update([FromBody]InfoEntity info)
        //{
        //    List<CommentEntity> commentsMock = new List<CommentEntity>();
        //    commentsMock.Add(new CommentEntity()
        //    {
        //        Id = 101,
        //        EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
        //        UserId = 10,
        //        ContentInfoId = 52,
        //        Content = "Odlicna atmosfera!!! =))"
        //    });
        //    commentsMock.Add(new CommentEntity()
        //    {
        //        Id = 102,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
        //        UserId = 11,
        //        ContentInfoId = 52,
        //        Content = "Katastrofa..."
        //    });
        //    commentsMock.Add(new CommentEntity()
        //    {
        //        Id = 103,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:34:32.17"),
        //        UserId = 10,
        //        ContentInfoId = 52,
        //        Content = "Ma sto katastrofa? o.O"
        //    });
        //    commentsMock.Add(new CommentEntity()
        //    {
        //        Id = 104,
        //        EndTime = Convert.ToDateTime("2016/12/26 14:22:08.07"),
        //        UserId = 12,
        //        ContentInfoId = 52,
        //        Content = "Bilo je ok!"
        //    });

        //    return new InfoEntity()
        //    {
        //        Id = 52,
        //        time = DateTime.Now,
        //        category = new CategoryEntity() { Id = 1, Name = "Koncert" },
        //        user = new UserEntity() { Id = 2, Username = "KorIme", Password = "123", FullName = "Marko Marić", IsActive = true, UserTypeId = 1 },
        //        place = new PlaceEntity() { Id = 102, Location = new GeoCoordinate(45.8118117, 15.9740687), Name = "Gajeva 4" },
        //        content = "Koncert za humaniratnu akciju 'Želim život'",
        //        endTime = DateTime.Now.AddDays(4.7),
        //        comments = commentsMock
        //    };
        //}

        //[Route("api/info/delete")]
        //[HttpDelete]
        //public bool Delete(int id)
        //{
        //    return true;
        //}

        #endregion

    }
}
