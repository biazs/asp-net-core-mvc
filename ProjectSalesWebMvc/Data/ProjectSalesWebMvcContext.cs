using Microsoft.EntityFrameworkCore;

namespace ProjectSalesWebMvc.Models
{
    public class ProjectSalesWebMvcContext : DbContext
    {
        public ProjectSalesWebMvcContext(DbContextOptions<ProjectSalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
