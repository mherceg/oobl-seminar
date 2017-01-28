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
    public class ReputationInfoRepository : EFRepository<ReputationInfoEntity, ReputationInfo>
    {
        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public ReputationInfoRepository(TracktorDb context) : base (context)
        {
        }
        #endregion

        #region Public member methods...

        /// <summary>
        /// Insert method for the place entities
        /// </summary>
        /// <param name="repInfoDomain"></param>
        /// <param name="saveChanges"></param>
        public int Insert(ReputationInfoEntity repInfoDomain, Action saveChanges)
        {
            ReputationInfo repInfoDAL = Mapper.ToDALModel(repInfoDomain);
            DbSet.Add(repInfoDAL);
            saveChanges();
            return repInfoDAL.Id;
        }

        /// <summary>
        /// Update method for reputation Info entities
        /// </summary>
        /// <param name="repInfo"></param>
        /// <param name="saveChanges"></param>
        /// <returns></returns>
        public bool Update(ReputationInfoEntity repInfo, Action saveChanges)
        {
            ReputationInfo repInfoNew = Mapper.ToDALModel(repInfo);
            ReputationInfo repInfoOld = DbSet.SingleOrDefault(ri => ri.UserId == repInfo.UserId && ri.InfoId == repInfo.ContentCommentId && ri.Score == !repInfo.Score);

            if (repInfoOld != null)
            {
                repInfoNew.Id = repInfoOld.Id;
                Context.Entry(repInfoOld).CurrentValues.SetValues(repInfoNew);
            }
            saveChanges();
            return true;
        }

        /// <summary>
        /// Delete method for the ReputationInfo entities
        /// </summary>
        /// <param name="reputationId"></param>
        /// <param name="saveChanges"></param>
        /// <returns></returns>
        public bool Delete(int reputationId, Action saveChanges)
        {
            ReputationInfo repInfoDAL = DbSet.FirstOrDefault(ri => ri.Id == reputationId);
            DbSet.Remove(repInfoDAL);
            saveChanges();
            return true;
        }

        /// <summary>
        /// specific method to check if entity exists
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns></returns>
        public bool Exists(Func<ReputationInfo, bool> predicate)
        {
            return this.Context.ReputationInfo.Any(predicate);
        }

        #endregion
    }
}
