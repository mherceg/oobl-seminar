using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    public class CommentEntity
    {
        public int Id { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public double Range { get; set; }
        public System.DateTime EndTime { get; set; }
        public int UserId { get; set; }
        public int ContentInfoId { get; set; }
    }
}
