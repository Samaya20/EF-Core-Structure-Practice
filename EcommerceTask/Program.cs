using ECommerceDataAccess.Context;
using ECommerceDataAccess.Repositories;
using ECommerceDataAccess.Repositories.Interfaces;
using ECommerceDataModels.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        E_commerceDb e_CommerceDb = new E_commerceDb();

        ICustomerRepository crepo = new CustomerRepo(e_CommerceDb);
        var cusAndOrder = crepo.CustomerWithOrder();

        foreach (var c in cusAndOrder)
        {
            Console.WriteLine($"{c.Id} - {c.FirstName}");

            foreach (var order in c.Orders)
            {
                Console.WriteLine($"Order :{order.Id} - {order.OrderDate}");
            }
        }
    }
}