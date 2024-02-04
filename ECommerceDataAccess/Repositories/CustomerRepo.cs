using ECommerceDataAccess.Context;
using ECommerceDataAccess.Repositories.Interfaces;
using ECommerceDataModels.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceDataAccess.Repositories
{
    public class CustomerRepo : GenericRepo<Customer>, ICustomerRepository
    {
        internal readonly E_commerceDb? _context;

        public CustomerRepo(E_commerceDb context)
        {
            _context = context;
        }

        public IEnumerable<Customer> CustomerWithOrder()
        {
            return _context.Customers
                            .Include(c => c.Orders)
                            .AsNoTracking()
                            .ToList();
        }
    }
}
