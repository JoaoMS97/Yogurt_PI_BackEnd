using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces;
using Yogurt.Infraestructure.Repositories.BaseRepository;

namespace Yogurt.Infraestructure.Repositories
{
    public class CommentRepository : RepositoryBase<EntityBase>, ICommentRepository
    {
        public CommentRepository(YogurtContext context) : base(context)
        {
        }


    }
}
