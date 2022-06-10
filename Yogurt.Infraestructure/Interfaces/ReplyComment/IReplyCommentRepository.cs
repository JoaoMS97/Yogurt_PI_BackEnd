using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities.Base;
using Yogurt.Domain.Entities.ReplyComment;
using Yogurt.Infraestructure.Interfaces.BaseInterface;

namespace Yogurt.Infraestructure.Interfaces.ReplyComment
{
    public interface IReplyCommentRepository : IRepositoryAsync<ReplyCommentEntity>
    {

    }
}
