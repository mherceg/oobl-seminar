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

        public int NewInfo(InfoEntity info)
        {
            //Mapper da odradi ili jos bolje da repo prima domain class
            var new_info = new Info()
            {
                Time = info.time,
                EndTime = info.endTime,
                Content = info.content,
                CategoryId = info.categoryId,
                UserId = info.userId,
                PlaceId = info.placeId
            };
            _unitOfWork.InfoRepository.Insert(new_info);
            _unitOfWork.Save();
            return new_info.Id;
        }

        public int NewInfo(InfoEntity info, PlaceEntity place)
        {
            //Mapper da odradi ili jos bolje da repo prima domain class
            var new_place = new Place()
            {
                Name = place.Name,
                Location = DbGeography.PointFromText(String.Format("POINT({0} {1})", place.Location.Longitude, place.Location.Latitude), 4326)
            };
            _unitOfWork.PlaceRepository.Insert(new_place);
            _unitOfWork.Save();
            var new_info = new Info()
            {
                Time = info.time,
                EndTime = info.endTime,
                Content = info.content,
                CategoryId = info.categoryId,
                UserId = info.userId,
                PlaceId = new_place.Id
            };

            _unitOfWork.InfoRepository.Insert(new_info);
            _unitOfWork.Save();
            return new_info.Id;
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
