
using Microsoft.EntityFrameworkCore;

namespace FirstDBConnection
{
    public class HepsiSuradaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=myServerAddress;" +
                "Database=myDataBase;" +
                "Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
