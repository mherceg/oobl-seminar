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
    public class CommentRepository : EFRepository<CommentEntity, Comment>
    {
        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public CommentRepository(TracktorDb context) : base(context)
        {
        }
        #endregion

        #region Public member methods...

        /// <summary>
        /// Insert method for the comment entities
        /// </summary>
        /// <param name="commentDomain"></param>
        /// <param name="saveChanges"></param>
        public int Insert(CommentEntity commentDomain, Action saveChanges)
        {
            Comment commentDAL = Mapper.ToDALModel(commentDomain);
            DbSet.Add(commentDAL);
            saveChanges();
            return commentDAL.Id;
        }



        #endregion
    }
}
