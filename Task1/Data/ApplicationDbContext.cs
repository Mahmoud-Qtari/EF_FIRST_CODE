using Microsoft.EntityFrameworkCore;
using Task1.Models;

namespace Task1.Data
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2VPR9IB;Database=ASP9_EF;Trusted_Connection=true;TrustServerCertificate=True");
        }
        DbSet<Product> products {  get; set; }
    }
}
