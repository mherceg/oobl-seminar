using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Business.Implementation;
using Tracktor.Business.Interface;
using Tracktor.DAL.Database;

namespace Tracktor.Business
{
    public static class ServiceFactory
    {
        public static IUserServices getUserServices(TracktorDb context = null)
        {
            if (context != null)
            {
                return new UserServices(context);
            }
            return new UserServices();
        }

        public static IPlaceServices getPlaceServices(TracktorDb context = null)
        {
            if (context != null)
            {
                return new PlaceServices(context);
            }
            return new PlaceServices();
        }

        public static IInfoServices getInfoServices(TracktorDb context = null)
        {
            if (context != null)
            {
                return new InfoServices(context);
            }
            return new InfoServices();
        }

        public static ICommentServices getCommentServices(TracktorDb context = null)
        {
            if (context != null)
            {
                return new CommentServices(context);
            }
            return new CommentServices();
        }

        public static ICategoryServices getCategoryServices(TracktorDb context = null)
        {
            if (context != null)
            {
                return new CategoryServices(context);
            }
            return new CategoryServices();
        }

        public static IUserTypeServices getUserTypeServices(TracktorDb context = null)
        {
            if (context != null)
            {
                return new UserTypeServices(context);
            }
            return new UserTypeServices();
        }

    }
}
