using ECommerceDataModels.Entities.Base;

namespace ECommerceDataModels.Entities
{
    public class Order: BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public string? OrderDetail { get; set; }
        public string? OrderStatus { get; set;}

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
