using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Application.Dto;

namespace Yogurt.Application.Interfaces.ReplyComment
{
    public interface IReplyCommentService
    {
        Task<ReturnDto> InsertReplyComment(Guid idComment, string response);
    }
}
