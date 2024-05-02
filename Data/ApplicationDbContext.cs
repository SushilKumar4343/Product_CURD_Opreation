using Microsoft.EntityFrameworkCore;
using Product_CURD.Models;

namespace Product_CURD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
