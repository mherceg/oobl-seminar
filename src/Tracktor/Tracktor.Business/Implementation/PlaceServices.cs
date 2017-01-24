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
    public class PlaceServices : IPlaceServices
    {
        private UnitOfWork _unitOfWork;

        public PlaceServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int Add(PlaceEntity place)
        {
            int new_id = _unitOfWork.PlaceRepository.Insert(place, _unitOfWork.Save);
            //_unitOfWork.Save();
            return new_id;
        }

        public bool Update(PlaceEntity place)
        {
            return _unitOfWork.PlaceRepository.Update(place, _unitOfWork.Save);
        }

        public bool Delete(int placeId)
        {
            return _unitOfWork.PlaceRepository.Delete(placeId, _unitOfWork.Save);
        }

        public List<PlaceEntity> GetByFilter(IDictionary<string, bool> filters, bool active, bool future)
        {
            return _unitOfWork.PlaceRepository.GetMany(filters, active, future).ToList();
        }

        public List<PlaceEntity> GetFavorite(int userId)
        {
            return _unitOfWork.PlaceRepository.GetFavorite(userId).ToList();
        }

        public List<PlaceEntity> GetSponsorship(int userId)
        {
            return _unitOfWork.PlaceRepository.GetSponsorship(userId).ToList();
        }

        public List<PlaceEntity> GetAll()
        {
            return (List<PlaceEntity>)_unitOfWork.PlaceRepository.GetAll();
        }
    }
}