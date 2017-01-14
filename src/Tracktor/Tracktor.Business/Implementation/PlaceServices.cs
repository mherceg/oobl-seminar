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
            var new_place = new Place()
            {
                Name = place.Name,
                Location = DbGeography.PointFromText(String.Format("POINT({0} {1})", place.Location.Longitude, place.Location.Latitude), 4326)
            };
            _unitOfWork.PlaceRepository.Insert(new_place);
            _unitOfWork.Save();
            return new_place.Id;
        }

        public List<PlaceEntity> GetByFilter(IDictionary<string, bool> filters, bool active, bool future)
        {
            //treba od ulaznih parametara formirati funkciju koja filtrira mjesta po kriteriju
            //return _unitOfWork.PlaceRepository.GetMany(p => p.Info.);
            throw new NotImplementedException();
        }

        public List<PlaceEntity> GetSponsorship(int userId)
        {
            //treba razmisliti da se ovo obavi razinu nize odnosno da se napravi specificni repositorij koji moze ovo obaviti i vratiti List<Place>
            var sponsorshipPlace = _unitOfWork.SponsorshipRepository.GetMany(s => s.UserId == userId);
            List<Place> places = new List<Place>();
            foreach (var sp in sponsorshipPlace)
            {
                places.AddRange(_unitOfWork.PlaceRepository.GetMany(p => p.Sponsorship.Contains(sp)));
            }

            //tu bi trebalo mapirati List<Place> u List<PlaceEntity>

            throw new NotImplementedException();
        }

        public List<PlaceEntity> GetFavorite(int userId)
        {
            //treba razmisliti da se ovo obavi razinu nize odnosno da se napravi specificni repositorij koji moze ovo obaviti i vratiti List<Place>
            var favPlace = _unitOfWork.FavoritePlaceRepository.GetMany(f => f.UserId == userId);
            List<Place> places = new List<Place>();
            foreach(var fp in favPlace)
            {
                places.AddRange(_unitOfWork.PlaceRepository.GetMany(p => p.FavoritePlace.Contains(fp)));
            }

            //tu bi trebalo mapirati List<Place> u List<PlaceEntity>

            throw new NotImplementedException();
        }
    }
}