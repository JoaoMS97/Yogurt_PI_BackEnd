using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces;
using Yogurt.Infraestructure.Repositories.BaseRepository;

namespace Yogurt.Infraestructure.Repositories
{
    public sealed class UsuarioRepository : RepositoryBase<UserEntity>, IUserRepository
    {
        public UsuarioRepository(YogurtContext context) : base(context)
        {
        }

        public async Task<UserEntity?> GetByEmail(string email)
        {
            return YogurtContext.Set<UserEntity>().FirstOrDefault(x => x.Email == email);
        }

        public Task<UserEntity?> GetByUsername(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity?> GetByToken(string token)
        {
            throw new NotImplementedException();
        }

        public void UpdateToken(string token, UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassword(string password, UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
