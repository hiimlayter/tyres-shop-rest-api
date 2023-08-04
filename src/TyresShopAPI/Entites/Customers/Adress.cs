namespace TyresShopAPI.Models.Customers
{
    public class Adress : BaseModel
    {
        public string Street { get; set; } = string.Empty;

        public double HomeNumber { get; set; }

        public string City { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        Customer Customer { get; set; }

        public int CustomerId { get; set; }
    }
}
