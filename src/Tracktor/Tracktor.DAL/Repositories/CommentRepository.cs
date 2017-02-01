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

        /// <summary>
        /// Update method for comment entities
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="saveChanges"></param>
        /// <returns></returns>
        public bool Update(CommentEntity comment, Action saveChanges)
        {
            Comment commentDALnew = Mapper.ToDALModel(comment);
            Comment commentDALold = DbSet.Find(comment.Id);

            if (commentDALold != null)
            {
                Context.Entry(commentDALold).CurrentValues.SetValues(commentDALnew);
            }
            saveChanges();
            return true;
        }

        /// <summary>
        /// Delete method for comment entities
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="saveChanges"></param>
        /// <returns></returns>
        public bool Delete(int commentId, Action saveChanges)
        {
            Comment commentDAL = DbSet.FirstOrDefault(c => c.Id == commentId);
            DbSet.Remove(commentDAL);
            saveChanges();
            return true;
        }

		/// <summary>
		/// Get All method for Comment entities
		/// </summary>
		/// <returns></returns>
		public IEnumerable<CommentEntity> GetAll()
		{
			IEnumerable<Comment> commentsDAL = DbSet;
			List<CommentEntity> commentsDomain = new List<CommentEntity>();
			foreach (var comment in commentsDAL)
			{
				commentsDomain.Add(Mapper.ToDomainModel(comment));
			}
			return commentsDomain.OrderBy(c => c.UserId);
		}

		#endregion
	}
}
