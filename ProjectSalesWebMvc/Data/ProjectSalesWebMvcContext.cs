using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectSalesWebMvc.Models
{
    public class ProjectSalesWebMvcContext : DbContext
    {
        public ProjectSalesWebMvcContext (DbContextOptions<ProjectSalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectSalesWebMvc.Models.Department> Department { get; set; }
    }
}
