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

        public CommentServices(TracktorDb context = null)
        {
            if (context != null)
            {
                _unitOfWork = new UnitOfWork(context);
            }
            else
            {
                _unitOfWork = new UnitOfWork();
            }
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
			//_unitOfWork.ReputationCommentRepository.DeleteByCommentId(commentId, _unitOfWork.Save);
			return _unitOfWork.CommentRepository.Delete(commentId, _unitOfWork.Save);
        }


        //koristi reputationCommentRepository
        public bool Rate(ReputationCommentEntity repCom)
        {
            //Ako je ocjena ista obavijesti korisnika
            //Ako je razlicita - promijeni
            //Ako nije do sad ocijenjeno - ocijeni
            if (_unitOfWork.ReputationCommentRepository.Exists(ri => ri.UserId == repCom.UserId && ri.CommentId == repCom.ContentCommentId && ri.Score == repCom.Score))
            {
                throw new Exception("Već ste dali takvu ocjenu za ovaj komentar!");
            }
            else if (_unitOfWork.ReputationCommentRepository.Exists(ri => ri.UserId == repCom.UserId && ri.CommentId == repCom.ContentCommentId && ri.Score == !repCom.Score))
            {
                _unitOfWork.ReputationCommentRepository.Update(repCom, _unitOfWork.Save);
                return true;
            }
            else
            {
                _unitOfWork.ReputationCommentRepository.Insert(repCom, _unitOfWork.Save);
                return true;
            }

        }

        public bool DeleteReputation(int repId)
        {
            return _unitOfWork.ReputationCommentRepository.Delete(repId, _unitOfWork.Save);
        }

    }
}