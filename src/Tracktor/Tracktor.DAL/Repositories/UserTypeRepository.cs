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
    }
}
