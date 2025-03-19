using Microsoft.EntityFrameworkCore;
using ProjetoAPIEntityFramework.Model;

namespace ProjetoAPIEntityFramework.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
        public DbSet<ProjetoAPIEntityFramework.Model.Categoria> Categoria { get; set; } = default!;
        public DbSet<ProjetoAPIEntityFramework.Model.Produto> Produto { get; set; } = default!;
    }



}
