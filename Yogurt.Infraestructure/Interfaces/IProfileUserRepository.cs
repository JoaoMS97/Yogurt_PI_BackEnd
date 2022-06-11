using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Interfaces.BaseInterface;

namespace Yogurt.Infraestructure.Interfaces
{
    public interface IProfileUserRepository : IRepositoryAsync<ProfileUserEntity>
    {
        Task<ProfileUserEntity?> GetById(Guid id);

        Task<ProfileUserEntity?> GetByUserName(string userName);

        Task<ProfileUserEntity?> GetByBiography(string? biography);

        //Task<ProfileUserEntity?> GetByCity(string city);

        Task<ProfileUserEntity?> GetByProfilePhoto(byte[]? profilePhoto);        

        void UpdateUserName(string userName, ProfileUserEntity entity);

        void UpdateBiography(string? biography, ProfileUserEntity entity);

        //void UpdateCity(string city, ProfileUserEntity entity);

        void UpdateProfilePhoto(byte[]? profilePhoto, ProfileUserEntity entity);
    }
}
