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
            int new_id = _unitOfWork.CommentRepository.Insert(comment, _unitOfWork.Save);
            return new_id;
        }

        public bool Rate(ReputationCommentEntity repCom)
        {
            var repComment = new ReputationComment()
            {
                UserId = repCom.UserId,
                CommentId = repCom.ContentCommentId,
                Score = repCom.Score
            };
            _unitOfWork.ReputationCommentRepository.Insert(repComment);
            _unitOfWork.Save();
            return true;
        }
    }
}