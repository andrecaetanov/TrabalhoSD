using Microsoft.EntityFrameworkCore;
using TrabalhoSD.Models;

namespace TrabalhoSD.Context
{
    public class TrabalhoSDContext : DbContext
    {
        public TrabalhoSDContext(DbContextOptions<TrabalhoSDContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>().HasKey(m => m.Id);

            builder.Entity<Produto>().HasOne(p => p.Fornecedor).WithMany(f => f.Produtos);

            builder.Entity<Fornecedor>().HasKey(m => m.Id);

            base.OnModelCreating(builder);
        }
    }
}
