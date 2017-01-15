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
        //Dodavanje novog dogadjaja s postojecim mjestom
        [Route("api/info/add")]
        [HttpPost]
        [ResponseType(typeof(int))]
        public IHttpActionResult Add([FromBody]InfoPostDTO info)
        {
            int id = 0;
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    //Mapper da odradi
                    var infoDomain = new InfoEntity()
                    {
                        time = info.startTime,
                        endTime = info.endTime,
                        content = info.content,
                        categoryId = info.categoryId,
                        userId = info.userId,
                        placeId = info.placeId
                    };

                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    id = infoService.NewInfo(infoDomain);
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
                    //Mapper da odradi
                    var placeDomain = new PlaceEntity()
                    {
                        Name = info.Name,
                        Location = new GeoCoordinate(info.Latitude, info.Longitude)
                    };
                    var infoDomain = new InfoEntity()
                    {
                        time = info.startTime,
                        endTime = info.endTime,
                        content = info.content,
                        categoryId = info.categoryId,
                        userId = info.userId,
                    };

                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    id = infoService.NewInfo(infoDomain, placeDomain);
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
                //Treba implementirati
                try
                {
                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    var infoDomain = infoService.GetByFilter(filters, active, future, PlaceId);

                    //events = MapInfo(infoDomain);

                    //Prvi Info
                    List<CommentDTO> komentari1 = new List<CommentDTO>();
                    komentari1.Add(new CommentDTO()
                    {
                        Id = 47,
                        time = Convert.ToDateTime("2016/12/25 20:18:42.35"),
                        user = "Pero Perić",
                        content = "Stvarno kul!",
                        reputation = 7
                    });
                    komentari1.Add(new CommentDTO()
                    {
                        Id = 49,
                        time = Convert.ToDateTime("2016/12/25 19:25:42.35"),
                        user = "Marko Marić",
                        content = "Odlicno",
                        reputation = 1
                    });
                    komentari1.Add(new CommentDTO()
                    {
                        Id = 102,
                        time = Convert.ToDateTime("2016/12/27 01:05:42.35"),
                        user = "Anonimni Korisnik =)",
                        content = "Meni je bilo ok, nista posebno",
                        reputation = -4
                    });
                    events.Add(new InfoDTO()
                    {
                        Id = 12,
                        startTime = Convert.ToDateTime("2016/12/24 15:00:42.35"),
                        endTime = Convert.ToDateTime("2016/12/27 20:00:42.35"),
                        content = "Humanitarni koncert za oboljele...",
                        category = "Kulturni Događaj",
                        user = "Grad Zagreb",
                        place = "KD Vatroslav Lisinski",
                        reputation = 104,
                        comments = komentari1
                    });

                    //Drugi Info
                    List<CommentDTO> komentari2 = new List<CommentDTO>();
                    komentari2.Add(new CommentDTO()
                    {
                        Id = 47,
                        time = Convert.ToDateTime("2017/01/11 20:18:42.35"),
                        user = "Pero Perić",
                        content = "Što nitko nije išao?",
                        reputation = 0
                    });
                    events.Add(new InfoDTO()
                    {
                        Id = 12,
                        startTime = Convert.ToDateTime("2017/01/11 16:00:00.00"),
                        endTime = Convert.ToDateTime("2017/01/11 18:00:00.00"),
                        content = "KK Cedevita vs. KK Cibona",
                        category = "Sportski Događaj",
                        user = "KK Cedevita",
                        place = "Dom Sportova",
                        reputation = 1,
                        comments = komentari2
                    });

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
                //Treba implementirati
                try
                {
                    //IInfoServices infoService = ServiceFactory.getInfoServices();
                    //var infoDomain = return infoService.GetByPlace(filters, active);

                    //events = MapInfo(infoDomain);

                    //Prvi Info
                    List<CommentDTO> komentari1 = new List<CommentDTO>();
                    komentari1.Add(new CommentDTO()
                    {
                        Id = 47,
                        time = Convert.ToDateTime("2016/12/25 20:18:42.35"),
                        user = "Pero Perić",
                        content = "Stvarno kul!",
                        reputation = 7
                    });
                    komentari1.Add(new CommentDTO()
                    {
                        Id = 49,
                        time = Convert.ToDateTime("2016/12/25 19:25:42.35"),
                        user = "Marko Marić",
                        content = "Odlicno",
                        reputation = 1
                    });
                    komentari1.Add(new CommentDTO()
                    {
                        Id = 102,
                        time = Convert.ToDateTime("2016/12/27 01:05:42.35"),
                        user = "Anonimni Korisnik =)",
                        content = "Meni je bilo ok, nista posebno",
                        reputation = -4
                    });
                    events.Add(new InfoDTO()
                    {
                        Id = 12,
                        startTime = Convert.ToDateTime("2016/12/24 15:00:42.35"),
                        endTime = Convert.ToDateTime("2016/12/27 20:00:42.35"),
                        content = "Humanitarni koncert za oboljele...",
                        category = "Kulturni Događaj",
                        user = "Grad Zagreb",
                        place = "Teatar Exit",
                        reputation = 104,
                        comments = komentari1
                    });

                    //Drugi Info
                    List<CommentDTO> komentari2 = new List<CommentDTO>();
                    komentari2.Add(new CommentDTO()
                    {
                        Id = 47,
                        time = Convert.ToDateTime("2017/01/11 20:18:42.35"),
                        user = "Pero Perić",
                        content = "Što nitko nije išao?",
                        reputation = 0
                    });
                    events.Add(new InfoDTO()
                    {
                        Id = 12,
                        startTime = Convert.ToDateTime("2017/01/11 16:00:00.00"),
                        endTime = Convert.ToDateTime("2017/01/11 18:00:00.00"),
                        content = "KK Cedevita vs. KK Cibona",
                        category = "Sportski Događaj",
                        user = "KK Cedevita",
                        place = "Teatar Exit",
                        reputation = 1,
                        comments = komentari2
                    });

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

            return Ok(events);
        }


        //Ocjenjivanje dogadjaja
        [Route("api/info/rate")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult Rate(int infoId, int userId, bool score)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                //Treba implementirati
                try
                {
                    IInfoServices infoService = ServiceFactory.getInfoServices();
                    success = infoService.Rate(infoId, userId, score);
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
