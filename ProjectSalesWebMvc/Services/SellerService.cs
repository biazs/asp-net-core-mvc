using System.Collections.Generic;
using System.Linq;
using ProjectSalesWebMvc.Models;

namespace ProjectSalesWebMvc.Services
{
    public class SellerService
    {
        private readonly ProjectSalesWebMvcContext _context;

        public SellerService(ProjectSalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
