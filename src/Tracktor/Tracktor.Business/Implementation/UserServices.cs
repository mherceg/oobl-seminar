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
    public class UserServices : IUserServices
    {

        private UnitOfWork _unitOfWork;

        public UserServices() {
            _unitOfWork = new UnitOfWork(); 
        }

        public int Login(LoginEntity le)
        {
            var userEntity = _unitOfWork.UserRepository.GetSingle(u => u.Username == le.Username && u.Password == le.Password);
            return userEntity.Id;
        }

        public int Register(UserEntity user)
        {
            var new_user = new User() { Username = user.Username, FullName = user.FullName, Password = user.Password, UserTypeId = user.UserTypeId };
            _unitOfWork.UserRepository.Insert(new_user);
            _unitOfWork.Save();
            return new_user.Id;
        }

        public UserEntity Get(int id)
        {
            var user = _unitOfWork.UserRepository.GetByID(id);
            //Map User to UserEntity
            return new UserEntity();
        }


        public bool AddFavouritePlace(int userId, int placeId)
        {
            //Mapper?
            var new_favPlace = new FavoritePlace()
            {
                UserId = userId,
                PlaceId = placeId
            };
            _unitOfWork.FavoritePlaceRepository.Insert(new_favPlace);
            _unitOfWork.Save();
            return true;
        }

        public bool AddSponsorPlace(int userId, int placeId)
        {
            //Mapper?
            var new_sponsorPlace = new Sponsorship()
            {
                UserId = userId,
                PlaceId = placeId
            };
            _unitOfWork.SponsorshipRepository.Insert(new_sponsorPlace);
            _unitOfWork.Save();
            return true;
        }

        public bool RemoveFavouritePlace(int userId, int placeId)
        {
            //Napraviti u specificnom repositoriju metodu koja prima userId i placeId i po tome brise (to je prirodni kljuc ove relacije)
            var favPlace = _unitOfWork.FavoritePlaceRepository.GetFirst(p => p.UserId == userId && p.PlaceId == placeId);
            _unitOfWork.FavoritePlaceRepository.Delete(favPlace.Id);
            _unitOfWork.Save();
            return true;
        }

        public bool RemoveSponsorPlace(int userId, int placeId)
        {
            //Napraviti u specificnom repositoriju metodu koja prima userId i placeId i po tome brise (to je prirodni kljuc ove relacije)
            var sponsorPlace = _unitOfWork.SponsorshipRepository.GetFirst(p => p.UserId == userId && p.PlaceId == placeId);
            _unitOfWork.SponsorshipRepository.Delete(sponsorPlace.Id);
            _unitOfWork.Save();
            return true;
        }

    }
}
