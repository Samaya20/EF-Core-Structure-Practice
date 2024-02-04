using ECommerceDataModels.Entities;

namespace ECommerceDataAccess.Repositories.Interfaces
{
    public interface ICustomerRepository: IGenericRepository<Customer>
    {
        IEnumerable<Customer> CustomerWithOrder();
    }
}
