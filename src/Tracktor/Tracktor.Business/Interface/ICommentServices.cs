using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracktor.Domain;

namespace Tracktor.Business.Interface
{
    public interface ICommentServices
    {
        int Add(CommentEntity comment);

        bool Update(CommentEntity comment);

        bool Delete(int commentId);

        bool Rate(ReputationCommentEntity repCom);

        bool DeleteReputation(int repId);
    }
}
