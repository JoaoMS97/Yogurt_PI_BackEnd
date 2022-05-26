using Yogurt.Domain.Entities;

namespace Yogurt.Infraestructure.Interfaces
{
    public interface IUsuarioRepository : IRepositoryAsync<UsuarioEntity>
    {
        Task<UsuarioEntity?> GetByEmail(string email);

        Task<UsuarioEntity?> GetByToken(Guid token);
    }
}
