using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces;
using Yogurt.Infraestructure.Repositories.BaseRepository;

namespace Yogurt.Infraestructure.Repositories
{
    public sealed class UsuarioRepository : RepositoryBase<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(YogurtContext context) : base(context)
        {
        }

        public async Task<UsuarioEntity?> GetByEmail(string email)
        {
            return YogurtContext.Set<UsuarioEntity>().FirstOrDefault(x => x.Email == email);
        }

        public async Task<UsuarioEntity?> GetByToken(Guid token)
        {
            return YogurtContext.Set<UsuarioEntity>().FirstOrDefault(x => x.Token == token);
        }
    }
}
