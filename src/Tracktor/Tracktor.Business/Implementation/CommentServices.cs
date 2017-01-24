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

        public bool Update(CommentEntity comment)
        {
            return _unitOfWork.CommentRepository.Update(comment, _unitOfWork.Save);
        }

        public bool Delete(int commentId)
        {
            return _unitOfWork.CommentRepository.Delete(commentId, _unitOfWork.Save);
        }


        //koristi reputationCommentRepository
        public bool Rate(ReputationCommentEntity repCom)
        {
            _unitOfWork.ReputationCommentRepository.Insert(repCom, _unitOfWork.Save);
            return true;
        }

        public bool DeleteReputation(int repId)
        {
            return _unitOfWork.ReputationCommentRepository.Delete(repId, _unitOfWork.Save);
        }
    }
}