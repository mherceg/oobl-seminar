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

        //Obsolete
        //public double Range { get; set; }

        public System.DateTime EndTime { get; set; }
        public int UserId { get; set; }
        public int ContentInfoId { get; set; }
        public string Content { get; set; }

        //Agregat
        public UserEntity user { get; set; }
        public IEnumerable<ReputationCommentEntity> reputation { get; set; }

        public int GetReputation()
        {
            int value = 0;
            foreach (var rep in reputation)
            {
                if (rep.Score)
                    value++;
                else
                    value--;
            }
            return value;
        }
    }
}
