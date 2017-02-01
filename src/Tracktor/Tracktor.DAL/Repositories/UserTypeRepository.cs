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
    public class UserTypeRepository : EFRepository<UserTypeEntity, UserType>
    {
        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public UserTypeRepository(TracktorDb context) : base(context)
        {
        }
        #endregion

        /// <summary>
        /// Get All method for UserType entities
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserTypeEntity> GetAll()
        {
            IEnumerable<UserType> userTypesDAL = DbSet;
            List<UserTypeEntity> userTypesDomain = new List<UserTypeEntity>();
            foreach (var userType in userTypesDAL)
            {
                userTypesDomain.Add(Mapper.ToDomainModel(userType));
            }
            return userTypesDomain.OrderBy(ut => ut.Type);
        }

		/// <summary>
		/// Insert method for the usertype entities
		/// </summary>
		/// <param name="usertypeDomain"></param>
		/// <param name="saveChanges"></param>
		public int Insert(UserTypeEntity usertypeDomain, Action saveChanges)
		{
			UserType usertypeDAL = Mapper.ToDALModel(usertypeDomain);
			DbSet.Add(usertypeDAL);
			saveChanges();
			return usertypeDAL.Id;
		}

		/// <summary>
		/// Update method for usertype entities
		/// </summary>
		/// <param name="usertype"></param>
		/// <param name="saveChanges"></param>
		/// <returns></returns>
		public bool Update(UserTypeEntity utDomain, Action saveChanges)
		{
			UserType utDAL = Mapper.ToDALModel(utDomain);
			utDAL.Id = utDomain.Id;
			this.Context.Entry(utDAL).State = System.Data.Entity.EntityState.Modified;
			saveChanges();
			return true;
		}

		/// <summary>
		/// Delete method for usertype entities
		/// </summary>
		/// <param name="usertypeId"></param>
		/// <param name="saveChanges"></param>
		/// <returns></returns>
		public bool Delete(int usertypeId, Action saveChanges)
		{
			UserType usertypeDAL = DbSet.FirstOrDefault(c => c.Id == usertypeId);
			DbSet.Remove(usertypeDAL);
			saveChanges();
			return true;
		}
	}
}
