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
    public class CategoryRepository : EFRepository<CategoryEntity, Category>
    {
        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public CategoryRepository(TracktorDb context) : base(context)
        {
        }
        #endregion

        #region Public member methods...

        /// <summary>
        /// Insert method for the place entities
        /// </summary>
        /// <param name="placeDomain"></param>
        /// <param name="saveChanges"></param>
        public int Insert(CategoryEntity categoryDomain, Action saveChanges)
        {
            Category categoryDAL = Mapper.ToDALModel(categoryDomain);
            DbSet.Add(categoryDAL);
            saveChanges();
            return categoryDAL.Id;
        }

        /// <summary>
        /// Get All method for place entities
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<CategoryEntity> GetAll()
        {
            IEnumerable<Category> categoriesDAL = DbSet;
            List<CategoryEntity> categoriesDomain = new List<CategoryEntity>();
            foreach (var category in categoriesDAL)
            {
                categoriesDomain.Add(Mapper.ToDomainModel(category));
            }
            return categoriesDomain.OrderBy(c => c.Name);
        }

        #endregion
    }
}
