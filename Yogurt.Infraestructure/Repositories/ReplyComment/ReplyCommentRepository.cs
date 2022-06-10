using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities.Base;
using Yogurt.Domain.Entities.ReplyComment;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces.ReplyComment;
using Yogurt.Infraestructure.Repositories.BaseRepository;

namespace Yogurt.Infraestructure.Repositories.ReplyComment
{
    public class ReplyCommentRepository : RepositoryBase<ReplyCommentEntity>, IReplyCommentRepository
    {
        public ReplyCommentRepository(YogurtContext context) : base(context)
        {
        }
    }
}
