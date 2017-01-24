using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Domain;

namespace Tracktor.Business.Interface
{
    public interface ICategoryServices
    {
        int Insert(CategoryEntity category);

        bool Update(CategoryEntity category);

        bool Delete(int categoryId);

        List<CategoryEntity> ListAll();
    }
}
