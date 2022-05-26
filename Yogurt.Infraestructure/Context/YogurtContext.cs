using Microsoft.EntityFrameworkCore;
using Yogurt.Domain.Entities;

namespace Yogurt.Infraestructure.Context
{
    public class YogurtContext : DbContext
    {
        public YogurtContext(DbContextOptions options) : base(options) { }

        public DbSet<UsuarioEntity> UsuarioEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
