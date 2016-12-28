using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tracktor.Domain;

namespace Tracktor.WebService.Controllers
{
    public class CategoryController : ApiController
    {
        public IEnumerable<CategoryEntity> List()
        {
            List<CategoryEntity> ret = new List<CategoryEntity>();
            ret.Add(new CategoryEntity()
            {
                Id = 0,
                Name = "Nocni zivot"
            });
            ret.Add(new CategoryEntity()
            {
                Id = 1,
                Name = "Pokemon"
            });
            ret.Add(new CategoryEntity()
            {
                Id = 2,
                Name = "Blic"
            });

            return ret;
        }

        public int Add(string name)
        {
            return 7;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}
