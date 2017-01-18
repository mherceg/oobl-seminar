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

        public CategoryServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        public List<CategoryEntity> ListAll()
        {
            return _unitOfWork.CategoryRepository.GetAll().ToList();
        }
    }
}
