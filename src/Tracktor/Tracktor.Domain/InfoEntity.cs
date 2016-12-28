using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    public class InfoEntity
    {
        public int Id { get; set; }
        public DateTime time { get; set; }
        public CategoryEntity category { get; set; }
        public UserEntity user { get; set; }
        public PlaceEntity place { get; set; }
        public string content { get; set; }
        public DateTime endTime { get; set; }
        public IEnumerable<CommentEntity> comments { get; set; }
    }
}
