using TyresShopAPI.Entities;
using TyresShopAPI.Models.Customers;

namespace TyresShopAPI.Entites.Customers
{
    public class Customer : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public Adress Address { get; set; }
        public int AdressId { get; set; }
    }
}
