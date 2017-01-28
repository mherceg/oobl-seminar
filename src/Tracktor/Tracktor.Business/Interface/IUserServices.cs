using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Domain;

namespace Tracktor.Business.Interface
{
    public interface IUserServices
    {
        int Register(UserEntity user);
        int Login(LoginEntity le);
        UserEntity Get(int id);


        bool AddFavouritePlace(int userId, int placeId);
        bool AddSponsorPlace(int userId, int placeId);
        bool RemoveFavouritePlace(int userId, int placeId);
        bool RemoveSponsorPlace(int userId, int placeId);
    }
}
