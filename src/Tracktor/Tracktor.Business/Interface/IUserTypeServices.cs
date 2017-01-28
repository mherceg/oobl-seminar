using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Domain;

namespace Tracktor.Business.Interface
{
    public interface IUserTypeServices
    {
        List<UserTypeEntity> ListAll();
    }
}
