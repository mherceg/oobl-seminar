using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Business.Interface;
using Tracktor.DAL.Database;
using Tracktor.DAL.UnitOfWork;
using Tracktor.Domain;

namespace Tracktor.Business.Implementation
{
    public class CommentServices : ICommentServices
    {
        private UnitOfWork _unitOfWork;

        public CommentServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int Add(CommentEntity comment)
        {
            var new_com = new Comment()
            {
                Time = comment.EndTime,
                UserId = comment.UserId,
                InfoId = comment.ContentInfoId,
                Content = comment.Content
            };

            _unitOfWork.CommentRepository.Insert(new_com);
            _unitOfWork.Save();
            return new_com.Id;
        }

        public bool Rate(int commentId, int userId, bool score)
        {
            var repComment = new ReputationComment()
            {
                UserId = userId,
                CommentId = commentId,
                Score = score
            };
            _unitOfWork.ReputationCommentRepository.Insert(repComment);
            _unitOfWork.Save();
            return true;
        }
    }
}