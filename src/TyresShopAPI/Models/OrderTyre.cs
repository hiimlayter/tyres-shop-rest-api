namespace TyresShopAPI.Models
{
    public class OrderTyre : BaseModel
    {
        public Order Order { get; set; } = new Order();
        public int OrderId { get; set; }

        public Tyre Tyre { get; set; } = new Tyre();

        public int TyreId { get; set; }

        public int Quantityt { get; set; }
    }
}
