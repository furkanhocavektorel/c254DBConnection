using FirstDBConnection.entity;
using Microsoft.EntityFrameworkCore;

namespace FirstDBConnection.context
{
    public class HepsiSuradaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB501-OGRETMEN;" +
                "Database=c254db;" +
                "Trusted_Connection=true;" +
                "TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
