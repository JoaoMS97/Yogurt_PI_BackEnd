using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces;
using Yogurt.Infraestructure.Repositories.BaseRepository;

namespace Yogurt.Infraestructure.Repositories
{
    public class UsuarioRepository : RepositoryBase<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(YogurtContext context) : base(context)
        {
        }

        public async Task<UsuarioEntity?> GetByEmail(string email)
        {
            return YogurtContext.Set<UsuarioEntity>().FirstOrDefault(x => x.Email == email);
        }

        public async Task<UsuarioEntity?> GetByUsername(string userName)
        {
            return YogurtContext.Set<UsuarioEntity>().FirstOrDefault(x => x.UserName == userName);
        }

        public async Task<UsuarioEntity?> GetByToken(string token)
        {
            return YogurtContext.Set<UsuarioEntity>().FirstOrDefault(x => x.Token == token);
        }

        public void UpdateToken(string token, UsuarioEntity entity)
        {
            try
            {
                var result = YogurtContext.UsuarioEntity.FirstOrDefault(item => item.Id == entity.Id);

                if (entity != null)
                {
                    entity.Password = token;
                    YogurtContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar o token no banco de dados. /n StackTrace: {ex}");
            }
        }

        public void UpdatePassword(string password, UsuarioEntity entity)
        {
            try
            {
                var result = YogurtContext.UsuarioEntity.FirstOrDefault(item => item.Id == entity.Id);

                if (entity != null)
                {
                    entity.Password = password;
                    YogurtContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar a senha no banco de dados. /n StackTrace: {ex}");
            }
        }

    }
}
