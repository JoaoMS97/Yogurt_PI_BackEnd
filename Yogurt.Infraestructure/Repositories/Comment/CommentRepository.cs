﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities.Comment;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces.Comment;
using Yogurt.Infraestructure.Repositories.BaseRepository;

namespace Yogurt.Infraestructure.Repositories.Comment
{
    public class CommentRepository : RepositoryBase<CommentEntity>, ICommentRepository
    {
        public CommentRepository(YogurtContext context) : base(context)
        {
        }
        public async Task<CommentEntity?> GetByGuid(Guid id)
        {
            return await YogurtContext.Set<CommentEntity>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateLike(int like, CommentEntity entity)
        {
            try
            {
                var result = await YogurtContext.Comentarios.FirstOrDefaultAsync(item => item.Id == entity.Id);

                if (entity != null)
                {
                    entity.Curtidas = like;
                    YogurtContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar as curtidas no banco de dados. /n StackTrace: {ex}");
            }

            return like;
        }
    }
}