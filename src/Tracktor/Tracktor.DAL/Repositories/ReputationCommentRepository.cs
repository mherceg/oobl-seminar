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

        #endregion
    }
}
