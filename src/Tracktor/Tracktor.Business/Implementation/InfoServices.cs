using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
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

        //Unos novog infa s i bez mjesta
        public int NewInfo(InfoEntity info)
        {
            int new_id = _unitOfWork.InfoRepository.Insert(info, _unitOfWork.Save);
            //_unitOfWork.Save();
            return new_id;
        }

        public int NewInfo(InfoEntity info, PlaceEntity place)
        {
            info.placeId = _unitOfWork.PlaceRepository.Insert(place, _unitOfWork.Save);
            int new_id = _unitOfWork.InfoRepository.Insert(info, _unitOfWork.Save);
            //_unitOfWork.Save();
            return new_id;
        }


        //Dohvat svih po filteru za neko mjesto ili samo svih po mjestu
        public List<InfoEntity> GetByFilter(IDictionary<string, bool> filters, bool active, bool future, int placeId)
        {
            return _unitOfWork.InfoRepository.GetMany(filters, active, future, placeId).ToList();
        }

        public List<InfoEntity> GetByPlace(int placeId)
        {
            return _unitOfWork.InfoRepository.GetByPlace(placeId).ToList();
        }


        //Ocjenjivanje
        public bool Rate(ReputationInfoEntity repInfo)
        {
            int new_id = _unitOfWork.ReputationInfoRepository.Insert(repInfo, _unitOfWork.Save);
            //_unitOfWork.Save();
            return true;
        }

        public bool DeleteReputation(int repId)
        {
            return _unitOfWork.ReputationInfoRepository.Delete(repId, _unitOfWork.Save);
        }
    }
}
