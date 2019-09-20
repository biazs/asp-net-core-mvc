using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSalesWebMvc.Models;

namespace ProjectSalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly ProjectSalesWebMvcContext _context;

        public DepartmentService(ProjectSalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
