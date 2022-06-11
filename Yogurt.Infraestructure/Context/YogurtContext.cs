using Microsoft.EntityFrameworkCore;
using Yogurt.Domain.Entities;
using Yogurt.Domain.Entities.Comment;
using Yogurt.Domain.Entities.ComunidadeEntity;
using Yogurt.Domain.Entities.Publication;
using Yogurt.Domain.Entities.ReplyComment;
using Yogurt.Domain.Entities.User;

namespace Yogurt.Infraestructure.Context
{
    public class YogurtContext : DbContext
    {
        public YogurtContext(DbContextOptions options) : base(options) { }

        public DbSet<PublicacaoEntity> Publicacao { get; set; }
        public DbSet<UserEntity> Usuario { get; set; }
        public DbSet<CommentEntity> Comentarios { get; set; }
        public DbSet<ReplyCommentEntity> Resposta { get; set; }
        public DbSet<FileEntity> Arquivos { get; set; }
        public DbSet<CommunityEntity> Comunidade { get; set; }
        public DbSet<ProfileUserEntity> Perfil { get; set; }
        public DbSet<CityEntity> Cidade { get; set; }
        public DbSet<StatesEntity> Estado { get; set; }
        public DbSet<FriendEntity> Amizade { get; set; }
        public DbSet<ConnectEntity> Conectar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}