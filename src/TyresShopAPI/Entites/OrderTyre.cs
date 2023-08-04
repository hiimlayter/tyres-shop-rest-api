namespace TyresShopAPI.Models
{
    public class OrderTyre : BaseModel
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public Tyre Tyre { get; set; }

        public int TyreId { get; set; }

        public int Quantityt { get; set; }
    }
}
