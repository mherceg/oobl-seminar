using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Mobile
{
    class SessionManager
    {
        public static int SessionID { get; private set; }

        public static void BeginSession(int id)
        {
            SessionID = id;
        }
    }
}
