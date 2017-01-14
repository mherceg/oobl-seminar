using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Domain;

namespace Tracktor.Business.Interface
{
    public interface IInfoServices
    {
        //UseCase dohvat dogadjaja po filteru ili za odredjeno mjesto, ocjenjivanje dogadjaja
        List<InfoEntity> GetByFilter(IDictionary<string, bool> filters, bool active, bool future, int placeId);

        List<InfoEntity> GetByPlace(int placeId);

        bool Rate(int infoId, int userId, bool score);
    }
}
