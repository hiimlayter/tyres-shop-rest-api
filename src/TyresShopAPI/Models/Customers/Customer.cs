namespace TyresShopAPI.Models.Customers
{
    public class Customer : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public Adress Address { get; set; } = new Adress();

        public int AdressId { get; set; }
    }
}
