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
    public class UserTypeServices : IUserTypeServices
    {
        private UnitOfWork _unitOfWork;

        public UserTypeServices(TracktorDb context = null)
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

        public List<UserTypeEntity> ListAll()
        {
            return _unitOfWork.UserTypeRepository.GetAll().ToList();
        }
    }
}
