using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    public class FavoritePlaceEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlaceId { get; set; }
    }
}
