using TyresShopAPI.Entites.Customers;
using TyresShopAPI.Entities;

namespace TyresShopAPI.Entites
{
    public class Order: BaseModel
    {
        public List<OrderTyre> OrderTyres { get; set; } = new List<OrderTyre> { new OrderTyre() };

        public Customer Customer { get; set; }
    }
}
