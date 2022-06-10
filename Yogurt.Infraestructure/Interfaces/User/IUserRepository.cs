using Yogurt.Domain.Entities.User;
using Yogurt.Infraestructure.Interfaces.BaseInterface;

namespace Yogurt.Infraestructure.Interfaces.User
{
    public interface IUserRepository : IRepositoryAsync<UserEntity>
    {
        Task<UserEntity?> GetByEmail(string email);

        Task<UserEntity?> GetByUsername(string userName);

        Task<UserEntity?> GetByToken(string token);

        void UpdateToken(string token, UserEntity entity);

        void UpdatePassword(string password, UserEntity entity);
    }
}
