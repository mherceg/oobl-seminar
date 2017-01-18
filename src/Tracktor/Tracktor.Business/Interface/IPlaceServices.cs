using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Domain;

namespace Tracktor.Business.Interface
{
    public interface IPlaceServices
    {
        int Add(PlaceEntity place);

        List<PlaceEntity> GetByFilter(IDictionary<string, bool> filters, bool active, bool future);

        List<PlaceEntity> GetFavorite(int userId);

        List<PlaceEntity> GetSponsorship(int userId);

        List<PlaceEntity> GetAll();
    }
}

