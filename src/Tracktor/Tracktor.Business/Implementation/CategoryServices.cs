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
    public class CategoryServices : ICategoryServices
    {
        private UnitOfWork _unitOfWork;

        public CategoryServices(TracktorDb context = null)
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


        public int Insert(CategoryEntity category)
        {
            int new_id = _unitOfWork.CategoryRepository.Insert(category, _unitOfWork.Save);
            return new_id;
        }

        public bool Update(CategoryEntity category)
        {
            return _unitOfWork.CategoryRepository.Update(category, _unitOfWork.Save);
        }

        public bool Delete(int categoryId)
        {
            return _unitOfWork.CategoryRepository.Delete(categoryId, _unitOfWork.Save);
        }

        public List<CategoryEntity> ListAll()
        {
            return _unitOfWork.CategoryRepository.GetAll().ToList();
        }


    }
}
