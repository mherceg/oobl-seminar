using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.DAL.Database;
using Tracktor.DAL.EFRepository;
using Tracktor.Domain;

namespace Tracktor.DAL.Repositories
{
    public class ReputationCommentRepository : EFRepository<ReputationCommentEntity, ReputationComment>
    {
        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public ReputationCommentRepository(TracktorDb context) : base(context)
        {
        }
        #endregion

        #region Public member methods...

        /// <summary>
        /// Insert method for the ReputationComment entities
        /// </summary>
        /// <param name="repComDomain"></param>
        /// <param name="saveChanges"></param>
        public int Insert(ReputationCommentEntity repComDomain, Action saveChanges)
        {
            ReputationComment repComDAL = Mapper.ToDALModel(repComDomain);
            DbSet.Add(repComDAL);
            saveChanges();
            return repComDAL.Id;
        }

        /// <summary>
        /// Update method for reputation Info entities
        /// </summary>
        /// <param name="repComDomain"></param>
        /// <param name="saveChanges"></param>
        /// <returns></returns>
        public bool Update(ReputationCommentEntity repComDomain, Action saveChanges)
        {
            ReputationComment repInfoNew = Mapper.ToDALModel(repComDomain);
            ReputationComment repInfoOld = DbSet.SingleOrDefault(ri => ri.UserId == repComDomain.UserId && ri.CommentId == repComDomain.ContentCommentId && ri.Score == !repComDomain.Score);

            if (repInfoOld != null)
            {
                repInfoNew.Id = repInfoOld.Id;
                Context.Entry(repInfoOld).CurrentValues.SetValues(repInfoNew);
            }
            saveChanges();
            return true;
        }

        /// <summary>
        /// Delete method for the ReputationComment entities
        /// </summary>
        /// <param name="reputationId"></param>
        /// <param name="saveChanges"></param>
        /// <returns></returns>
        public bool Delete(int reputationId, Action saveChanges)
        {
            ReputationComment repComDAL = DbSet.FirstOrDefault(rc => rc.Id == reputationId);
            DbSet.Remove(repComDAL);
            saveChanges();
            return true;
        }

        /// <summary>
        /// specific method to check if entity exists
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns></returns>
        public bool Exists(Func<ReputationComment, bool> predicate)
        {
            return this.Context.ReputationComment.Any(predicate);
        }

		public IEnumerable<ReputationCommentEntity> GetAll()
		{
			IEnumerable<ReputationComment> repComsDAL = DbSet;
			List<ReputationCommentEntity> repComsDomain = new List<ReputationCommentEntity>();
			foreach (var repCom in repComsDAL)
			{
				repComsDomain.Add(Mapper.ToDomainModel(repCom));
			}
			return repComsDomain.OrderBy(c => c.ContentCommentId);
		}

		//to be continued...
		/*public IEnumerable<ReputationCommentEntity> GetAllByCommentId(int commentId)
		{
			IEnumerable<ReputationComment> repComsDAL = DbSet;
			List<ReputationCommentEntity> repComsDomain = new List<ReputationCommentEntity>();
			foreach (var repCom in repComsDAL)
			{
				if (repCom.CommentId == commentId)
				{
					repComsDomain.Add(Mapper.ToDomainModel(repCom));
				}
			}
			return repComsDomain.OrderBy(c => c.Id);
		}

		public void DeleteByCommentId(int commentId, Action saveChanges)
		{
			IEnumerable<ReputationComment> repComsDAL = DbSet;
			foreach (var repCom in repComsDAL)
			{
				if (repCom.CommentId == commentId)
				{
					Delete(repCom.Id, saveChanges);
				}
			}
		}*/

		#endregion
	}
}
