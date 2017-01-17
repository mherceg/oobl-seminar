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
        public DateTime endTime { get; set; }
        public string content { get; set; }


        //Lakse mapiranje u DAL
        public int categoryId { get; set; }
        public int userId { get; set; }
        public int placeId { get; set; }


        //kao agregat
        public CategoryEntity category { get; set; }
        public UserEntity user { get; set; }
        public PlaceEntity place { get; set; }
        public IEnumerable<CommentEntity> comments { get; set; }
        public IEnumerable<ReputationInfoEntity> reputation { get; set; }


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
