using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.WebService.Models;

namespace Tracktor.Mobile
{
    class SessionManager
    {
        public static int SessionID { get; private set; }
        public static int UserType { get; private set; }

        public static void BeginSession(UserDTO user)
        {
            SessionID = user.Id;
            UserType = user.UserTypeId;
        }

        public static bool IsPremium()
        {
            if (UserType == 2)
                return true;
            return false;
        }
    }
}
