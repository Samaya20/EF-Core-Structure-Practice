using ECommerceDataModels.Entities;

namespace ECommerceDataAccess.Repositories.Interfaces
{
    public interface ICategoryRepository: IGenericRepository<Category>
    {
        IEnumerable<Category>? CategoryWithProducts();
    }
}
