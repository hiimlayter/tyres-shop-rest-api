namespace TyresShopAPI.Models
{
    public class TyreCreate
    {
        public int ProducerId { get; set; }

        public string Model { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int ProductionYear { get; set; }

        public int SizeWidth { get; set; }

        public int SizeProfile { get; set; }

        public int SizeDiameter { get; set; }

        public TyresType TyresType { get; set; }

    }
}
