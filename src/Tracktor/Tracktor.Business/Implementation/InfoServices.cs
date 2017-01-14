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
    public class InfoServices : IInfoServices
    {
        private UnitOfWork _unitOfWork;

        public InfoServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        public List<InfoEntity> GetByFilter(IDictionary<string, bool> filters, bool active, bool future, int placeId)
        {
            //treba od ulaznih parametara formirati funkciju koja filtrira info po kriteriju

            throw new NotImplementedException();
        }

        public List<InfoEntity> GetByPlace(int placeId)
        {
            var placesDAL = _unitOfWork.InfoRepository.GetMany(i => i.PlaceId == placeId);
            //Treba List<Place> mapirati u List<PlaceEntity>

            throw new NotImplementedException();
        }

        public bool Rate(int infoId, int userId, bool score)
        {
            var repInfo = new ReputationInfo()
            {
                UserId = userId,
                InfoId = infoId,
                Score = score
            };
            _unitOfWork.ReputationInfoRepository.Insert(repInfo);
            _unitOfWork.Save();
            return true;
        }
    }
}
