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
        [Route("api/info/add")]
        [HttpPost]
        public int Add([FromBody]InfoEntity info)
        {
            return 2;
        }

        [Route("api/info/list")]
        [HttpGet]
        public IEnumerable<InfoEntity> List()
        {
            List<InfoEntity> infoList = new List<InfoEntity>();

            //Prvi info
            List<CommentEntity> commentsMock1 = new List<CommentEntity>();
            commentsMock1.Add(new CommentEntity()
            {
                Id = 101,
                EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
                UserId = 10,
                ContentInfoId = 52,
                Content = "Odlicna atmosfera!!! =))"
            });
            commentsMock1.Add(new CommentEntity()
            {
                Id = 102,
                EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
                UserId = 11,
                ContentInfoId = 52,
                Content = "Katastrofa..."
            });
            commentsMock1.Add(new CommentEntity()
            {
                Id = 103,
                EndTime = Convert.ToDateTime("2016/12/25 21:34:32.17"),
                UserId = 10,
                ContentInfoId = 52,
                Content = "Ma sto katastrofa? o.O"
            });
            commentsMock1.Add(new CommentEntity()
            {
                Id = 104,
                EndTime = Convert.ToDateTime("2016/12/26 14:22:08.07"),
                UserId = 12,
                ContentInfoId = 52,
                Content = "Bilo je ok!"
            });

            infoList.Add(new InfoEntity()
            {
                Id = 52,
                time = DateTime.Now,
                category = new CategoryEntity() { Id = 1, Name = "Koncert" },
                user = new UserEntity() { Id = 2, Username = "KorIme", Password = "123", FullName = "Marko Marić", IsActive = true, UserTypeId = 1 },
                place = new PlaceEntity() { Id = 102, Location = new GeoCoordinate(45.8118117, 15.9740687), Name = "Gajeva 4" },
                content = "Koncert za humaniratnu akciju 'Želim život'",
                endTime = DateTime.Now.AddDays(4.7),
                comments = commentsMock1
            });

            //Drugi info
            List<CommentEntity> commentsMock2 = new List<CommentEntity>();
            commentsMock2.Add(new CommentEntity()
            {
                Id = 201,
                EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
                UserId = 10,
                ContentInfoId = 52,
                Content = "Strava =))"
            });
            commentsMock2.Add(new CommentEntity()
            {
                Id = 202,
                EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
                UserId = 11,
                ContentInfoId = 52,
                Content = "Super"
            });


            infoList.Add(new InfoEntity()
            {
                Id = 52,
                time = DateTime.Now,
                category = new CategoryEntity() { Id = 1, Name = "Sportski događaj" },
                user = new UserEntity() { Id = 2, Username = "KorIme", Password = "123", FullName = "Marko Marić", IsActive = true, UserTypeId = 1 },
                place = new PlaceEntity() { Id = 102, Location = new GeoCoordinate(45.8123356, 15.9716064),, Name = "Cvjetni trg" },
                content = "Izvlaćenje startnih brojeva za Snježnu kraljicu",
                endTime = DateTime.Now.AddDays(4.7),
                comments = commentsMock2
            });

            return infoList;
        }

        //? prima samo id infoEntity objekta ili treba i informacija +/-
        [Route("api/info/rate")]
        [HttpPost]
        public bool Rate(int id)
        {
            return true;
        }

        [Route("api/info/update")]
        [HttpPut]
        public InfoEntity Update([FromBody]InfoEntity info)
        {
            List<CommentEntity> commentsMock = new List<CommentEntity>();
            commentsMock.Add(new CommentEntity()
            {
                Id = 101,
                EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
                UserId = 10,
                ContentInfoId = 52,
                Content = "Odlicna atmosfera!!! =))"
            });
            commentsMock.Add(new CommentEntity()
            {
                Id = 102,
                EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
                UserId = 11,
                ContentInfoId = 52,
                Content = "Katastrofa..."
            });
            commentsMock.Add(new CommentEntity()
            {
                Id = 103,
                EndTime = Convert.ToDateTime("2016/12/25 21:34:32.17"),
                UserId = 10,
                ContentInfoId = 52,
                Content = "Ma sto katastrofa? o.O"
            });
            commentsMock.Add(new CommentEntity()
            {
                Id = 104,
                EndTime = Convert.ToDateTime("2016/12/26 14:22:08.07"),
                UserId = 12,
                ContentInfoId = 52,
                Content = "Bilo je ok!"
            });

            return new InfoEntity()
            {
                Id = 52,
                time = DateTime.Now,
                category = new CategoryEntity() { Id = 1, Name = "Koncert" },
                user = new UserEntity() { Id = 2, Username = "KorIme", Password = "123", FullName = "Marko Marić", IsActive = true, UserTypeId = 1 },
                place = new PlaceEntity() { Id = 102, Location = new GeoCoordinate(45.8118117, 15.9740687), Name = "Gajeva 4" },
                content = "Koncert za humaniratnu akciju 'Želim život'",
                endTime = DateTime.Now.AddDays(4.7),
                comments = commentsMock
            };
        }

        [Route("api/info/delete")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return true;
        }

        [Route("api/info/get")]
        [HttpGet]
        public InfoEntity Get(int id)
        {
            List<CommentEntity> commentsMock = new List<CommentEntity>();
            commentsMock.Add(new CommentEntity()
            {
                Id = 101,
                EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
                UserId = 10,
                ContentInfoId = 52,
                Content = "Odlicna atmosfera!!! =))"
            });
            commentsMock.Add(new CommentEntity()
            {
                Id = 102,
                EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
                UserId = 11,
                ContentInfoId = 52,
                Content = "Katastrofa..."
            });
            commentsMock.Add(new CommentEntity()
            {
                Id = 103,
                EndTime = Convert.ToDateTime("2016/12/25 21:34:32.17"),
                UserId = 10,
                ContentInfoId = 52,
                Content = "Ma sto katastrofa? o.O"
            });
            commentsMock.Add(new CommentEntity()
            {
                Id = 104,
                EndTime = Convert.ToDateTime("2016/12/26 14:22:08.07"),
                UserId = 12,
                ContentInfoId = 52,
                Content = "Bilo je ok!"
            });

            return new InfoEntity()
            {
                Id = 52,
                time = DateTime.Now,
                category = new CategoryEntity() {Id=1, Name = "Koncert"},
                user = new UserEntity() {Id=2, Username="KorIme", Password="123", FullName="Marko Marić", IsActive=true, UserTypeId=1 },
                place = new PlaceEntity() {Id = 102, Location = new GeoCoordinate(45.8118117, 15.9740687), Name = "Gajeva 4"},
                content = "Koncert za humaniratnu akciju 'Želim život'",
                endTime = DateTime.Now.AddDays(4.7),
                comments = commentsMock
            };
        }



    }
}
