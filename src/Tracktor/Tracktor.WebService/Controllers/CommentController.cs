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
using Tracktor.WebService.Models;
using System.Web.Http.Description;

namespace Tracktor.WebService.Controllers
{
    public class CommentController : ApiController
    {
        private DTOAssembler _DTOAssempler { get; set; }
        public CommentController()
        {
            _DTOAssempler = new DTOAssembler();
        }

        //UseCase dodavanje i ocjenjivanje komentara
        [Route("api/comment/add")]
        [HttpPost]
        [ResponseType(typeof(int))]
        public IHttpActionResult Add([FromBody]CommentPostDTO comment)
        {
            int Id = 0;
            if(ModelState.IsValid)
            {
                try
                {
                    CommentEntity commentDomain = _DTOAssempler.CreateCommentEntity(comment);
                    ICommentServices commentService = ServiceFactory.getCommentServices();
                    Id = commentService.Add(commentDomain);
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

        [Route("api/comment/rate")]
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult Rate(RateCommentPostDTO reputationComment)
        {
            bool success = true;
            if (ModelState.IsValid)
            {
                try
                {
                    ReputationCommentEntity repCommentDomain = _DTOAssempler.CreateReputationCommentEntity(reputationComment);
                    ICommentServices commentService = ServiceFactory.getCommentServices();
                    success = commentService.Rate(repCommentDomain);
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


        #region Ne koristi se u use caseovima

        //[Route("api/comment/update")]
        //[HttpPut]
        //public CommentEntity Update([FromBody]CommentEntity comment)
        //{
        //    return new CommentEntity()
        //    {
        //        Id = 144,
        //        EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
        //        UserId = 10,
        //        ContentInfoId = 11,
        //        Content = "Odlicna atmosfera!!! =))"
        //    };
        //}

        //[Route("api/comment/delete")]
        //[HttpDelete]
        //public bool Delete(int id)
        //{
        //    return true;
        //}

        //[Route("api/comment/list")]
        //[HttpGet]
        //public IEnumerable<CommentEntity> List(int infoId)
        //{
        //    List<CommentEntity> comments = new List<CommentEntity>();
        //    comments.Add(new CommentEntity()
        //    {
        //        Id = 101,
        //        EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
        //        UserId = 10,
        //        ContentInfoId = infoId,
        //        Content = "Odlicna atmosfera!!! =))"
        //    });
        //    comments.Add(new CommentEntity()
        //    {
        //        Id = 102,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
        //        UserId = 11,
        //        ContentInfoId = infoId,
        //        Content = "Katastrofa..."
        //    });
        //    comments.Add(new CommentEntity()
        //    {
        //        Id = 103,
        //        EndTime = Convert.ToDateTime("2016/12/25 21:34:32.17"),
        //        UserId = 10,
        //        ContentInfoId = infoId,
        //        Content = "Ma sto katastrofa? o.O"
        //    });
        //    comments.Add(new CommentEntity()
        //    {
        //        Id = 104,
        //        EndTime = Convert.ToDateTime("2016/12/26 14:22:08.07"),
        //        UserId = 12,
        //        ContentInfoId = infoId,
        //        Content = "Bilo je ok!"
        //    });

        //    return comments;
        //}

        #endregion
    }
}