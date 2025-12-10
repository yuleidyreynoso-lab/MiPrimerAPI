using Microsoft.EntityFrameworkCore;
using MiPrimerAPI.Models;

namespace MiPrimerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Representa la tabla Products en la base de datos
        public DbSet<Product> Products { get; set; }
    }
}

