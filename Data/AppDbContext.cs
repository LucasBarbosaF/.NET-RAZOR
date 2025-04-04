using Microsoft.EntityFrameworkCore;
using ProjetoMvc.Models;
using WebApplication1.Models;

namespace ProjetoMvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}