using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    public class ReputationInfoEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ContentCommentId { get; set; }
        public bool Score { get; set; }

        //kao agregat
        public IEnumerable<UserEntity> user { get; set; }
    }
}
