using TyresShopAPI.Models.Customers;

namespace TyresShopAPI.Models
{
    public class Order: BaseModel
    {
        public List<OrderTyre> OrderTyres { get; set; } = new List<OrderTyre> { new OrderTyre() };

        public Customer Customer { get; set; }
    }
}
