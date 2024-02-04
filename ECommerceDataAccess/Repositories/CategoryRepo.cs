using ECommerceDataAccess.Context;
using ECommerceDataAccess.Repositories.Interfaces;
using ECommerceDataModels.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceDataAccess.Repositories
{
    public class CategoryRepo : GenericRepo<Category>, ICategoryRepository
    {
        internal readonly E_commerceDb? _context;

        public CategoryRepo(E_commerceDb context)
        {
            _context = context;
        }

        public IEnumerable<Category>? CategoryWithProducts()
        {
            return _context.Categories
                            .Include(c => c.Products)
                            .ToList();
        }
    }
}
