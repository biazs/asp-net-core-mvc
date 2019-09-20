using System.Collections.Generic;
using System.Linq;
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

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
