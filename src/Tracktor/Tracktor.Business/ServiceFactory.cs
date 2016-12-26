using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Business.Implementation;
using Tracktor.Business.Interface;

namespace Tracktor.Business
{
    public static class ServiceFactory
    {
        public static IUserServices getUserServices()
        {
            return new UserServices();
        }

    }
}
