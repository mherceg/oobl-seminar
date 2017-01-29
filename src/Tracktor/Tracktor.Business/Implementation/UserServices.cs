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

        public UserServices(TracktorDb context = null)
        {
            if (context != null)
            {
                _unitOfWork = new UnitOfWork(context);
            }
            else
            {
                _unitOfWork = new UnitOfWork(); 
            }
        }

        public int Login(LoginEntity le)
        {
            //Provjeri postoji li korisnik s tim korisnickim imenom i lozinkom
            //Ako ne javi gresku, ako da - provjeri je li mu racun aktiviran, ako ne javi gresku
            if(_unitOfWork.UserRepository.Exists(u => u.Username == le.Username && u.Password == le.Password))
            {
                var userEntity = _unitOfWork.UserRepository.GetSingle(u => u.Username == le.Username && u.Password == le.Password);
                if (!userEntity.IsActive)
                    throw new Exception("Korisnik nije aktiviran. Molimo obratite se administratoru.");

                return userEntity.Id;
            }
            else
            {
                throw new Exception("Neispravno korisničko ime ili loznika!");
            }
        }

        public int Register(UserEntity user)
        {
            //Pozovemo _context.SaveChanges iz repoa da dobijemo ID prilikom unosa u bazu

            int new_id = _unitOfWork.UserRepository.Insert(user, _unitOfWork.Save);
            //_unitOfWork.Save();

            return new_id;
        }

        public UserEntity Get(int id)
        {
            //Provjeri postoji li korisnik s tim Id-em
            //Ako ne javi gresku, ako da dohvati ga
            if (_unitOfWork.UserRepository.Exists(u => u.Id == id))
            {
                var user = _unitOfWork.UserRepository.GetByID(id);
                return user;
            }
            else
            {
                throw new Exception("Takav korisnik ne postoji!");
            }
        }


        public bool AddFavouritePlace(int userId, int placeId)
        {
            _unitOfWork.UserRepository.AddFavoritePlace(userId, placeId);
            _unitOfWork.Save();

            return true;
        }

        public bool AddSponsorPlace(int userId, int placeId)
        {
            _unitOfWork.UserRepository.AddSponsorPlace(userId, placeId);
            _unitOfWork.Save();

            return true;
        }

        public bool RemoveFavouritePlace(int userId, int placeId)
        {
            _unitOfWork.UserRepository.RemoveFavoritePlace(userId, placeId);
            _unitOfWork.Save();

            return true;
        }

        public bool RemoveSponsorPlace(int userId, int placeId)
        {
            _unitOfWork.UserRepository.RemoveSponsorPlace(userId, placeId);
            _unitOfWork.Save();

            return true;
        }

    }
}
