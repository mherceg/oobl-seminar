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
    public class CommentController : ApiController
    {
        [Route("api/comment/add")]
        [HttpPost]
        public int Add([FromBody]CommentEntity comment)
        {
            return comment.Id;
        }

        [Route("api/comment/update")]
        [HttpPatch]
        public CommentEntity Update([FromBody]CommentEntity comment)
        {
            return comment;
        }

        [Route("api/comment/delete")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return true;
        }

        [Route("api/comment/list")]
        [HttpGet]
        public IEnumerable<CommentEntity> List(int infoId)
        {
            List<CommentEntity> comments = new List<CommentEntity>();
            comments.Add(new CommentEntity()
            {
                Id = 101,
                EndTime = Convert.ToDateTime("2016/12/25 20:18:42.35"),
                UserId = 10,
                ContentInfoId = infoId,
                Content = "Odlicna atmosfera!!! =))"
            });
            comments.Add(new CommentEntity()
            {
                Id = 102,
                EndTime = Convert.ToDateTime("2016/12/25 21:33:15.47"),
                UserId = 11,
                ContentInfoId = infoId,
                Content = "Katastrofa..."
            });
            comments.Add(new CommentEntity()
            {
                Id = 103,
                EndTime = Convert.ToDateTime("2016/12/25 21:34:32.17"),
                UserId = 10,
                ContentInfoId = infoId,
                Content = "Ma sto katastrofa? o.O"
            });
            comments.Add(new CommentEntity()
            {
                Id = 104,
                EndTime = Convert.ToDateTime("2016/12/26 14:22:08.07"),
                UserId = 12,
                ContentInfoId = infoId,
                Content = "Bilo je ok!"
            });

            return comments;
        }


        //?
        [Route("api/comment/rate")]
        [HttpPost]
        public bool Rate([FromBody]ReputationCommentEntity repComment)
        {
            return true;
        }
    }
}