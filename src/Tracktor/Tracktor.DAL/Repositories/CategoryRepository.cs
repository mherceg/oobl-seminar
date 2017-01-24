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
        /// Insert method for the Category entities
        /// </summary>
        /// <param name="categoryDomain"></param>
        /// <param name="saveChanges"></param>
        public int Insert(CategoryEntity categoryDomain, Action saveChanges)
        {
            Category categoryDAL = Mapper.ToDALModel(categoryDomain);
            DbSet.Add(categoryDAL);
            saveChanges();
            return categoryDAL.Id;
        }

        /// <summary>
        /// Edit method for Category entities
        /// </summary>
        /// <param name="category"></param>
        /// <param name="saveChanges"></param>
        /// <returns></returns>
        public bool Update(CategoryEntity category, Action saveChanges)
        {
            Category categoryDALnew = Mapper.ToDALModel(category);
            Category categoryDALold = DbSet.Find(category.Id);

            if(categoryDALold != null)
            {
                Context.Entry(categoryDALold).CurrentValues.SetValues(categoryDALnew);
            }
            saveChanges();
            return true;
        }

        /// <summary>
        /// Delete method for Category entities
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool Delete(int categoryId, Action saveChanges)
        {
            Category categoryDAL = DbSet.FirstOrDefault(c => c.Id == categoryId);
            DbSet.Remove(categoryDAL);
            saveChanges();
            return true;
        }

        /// <summary>
        /// Get All method for Category entities
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CategoryEntity> GetAll()
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
