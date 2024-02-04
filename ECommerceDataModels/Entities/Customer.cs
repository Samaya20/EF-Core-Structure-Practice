using ECommerceDataModels.Entities.Base;

namespace ECommerceDataModels.Entities
{
    public class Customer : BaseEntity
    {
        public string? FirstName { get; set; } 
        public string? LastName { get; set;}
        public string? Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
