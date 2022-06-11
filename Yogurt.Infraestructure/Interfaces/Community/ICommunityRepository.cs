using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities.Comment;
using Yogurt.Domain.Entities.ComunidadeEntity;
using Yogurt.Infraestructure.Interfaces.BaseInterface;

namespace Yogurt.Infraestructure.Interfaces.Comment
{
    public interface ICommunityRepository : IRepositoryAsync<CommunityEntity>
    {
        Task<CommunityEntity?> GetByGuid(Guid id);

        void UpdateName(string nome, CommunityEntity entity);

        void UpdateSubtitle(string legenda, CommunityEntity entity);

        void UpdateImage(byte[] imagem, CommunityEntity entity);
    }
}
