using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities.Comment;
using Yogurt.Infraestructure.Interfaces.BaseInterface;

namespace Yogurt.Infraestructure.Interfaces.Comment
{
    public interface ICommentRepository : IRepositoryAsync<CommentEntity>
    {
        Task<CommentEntity?> GetByGuid(Guid id);

        Task<int> UpdateLike(int like, CommentEntity entity);

    }
}
