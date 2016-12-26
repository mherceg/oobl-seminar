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

        public int Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public int Register(UserEntity user)
        {
            var new_user = new User() { Username = user.Username, FullName = user.FullName, Password = user.Password};
            _unitOfWork.UserRepository.Insert(new_user);
            _unitOfWork.Save();
            return new_user.Id;
        }
    }
}
