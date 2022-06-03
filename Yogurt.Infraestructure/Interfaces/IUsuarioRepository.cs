using Yogurt.Domain.Entities;

namespace Yogurt.Infraestructure.Interfaces
{
    public interface IUsuarioRepository : IRepositoryAsync<UsuarioEntity>
    {
        Task<UsuarioEntity?> GetByEmail(string email);

        Task<UsuarioEntity?> GetByUsername(string userName);

        Task<UsuarioEntity?> GetByToken(string token);

        void UpdateToken(string token, UsuarioEntity entity);

        void UpdatePassword(string password, UsuarioEntity entity);
    }
}
