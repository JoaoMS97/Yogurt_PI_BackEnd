using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Application.Dto;

namespace Yogurt.Application.Interfaces.Comment
{
    public interface ICommentService
    {
        Task<ReturnDto> InsertComment(Guid idPublicacao, string Legenda);

        Task<ReturnDto> AddLike(Guid idComment);

        Task<ReturnDto> RemoveLike(Guid idComment);
    }
}
