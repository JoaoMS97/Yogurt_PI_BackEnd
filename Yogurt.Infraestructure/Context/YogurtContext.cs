using Microsoft.EntityFrameworkCore;
using Yogurt.Domain.Entities;

namespace Yogurt.Infraestructure.Context
{
    public class YogurtContext : DbContext
    {
        public YogurtContext(DbContextOptions options) : base(options) { }

        public DbSet<PublicacaoEntity> Publicacao { get; set; }
        public DbSet<UserEntity> Usuario { get; set; }

        public DbSet<CommentEntity> Comentarios { get; set; }

        public DbSet<ReplyCommentEntity> Resposta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
