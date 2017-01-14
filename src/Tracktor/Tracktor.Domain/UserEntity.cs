using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public int UserTypeId { get; set; }


        //kao agregat - treba mapirati
        public IEnumerable<PlaceEntity> FavoritePlaces { get; set; }

        public IEnumerable<PlaceEntity> SponsorshipPlaces { get; set; }

        public UserTypeEntity Type { get; set; }
    }
}
