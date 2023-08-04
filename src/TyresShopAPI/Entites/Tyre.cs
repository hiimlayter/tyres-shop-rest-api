using TyresShopAPI.Enums;

namespace TyresShopAPI.Entities
{
    public class Tyre: BaseModel
    {
        public Producer Producer { get; set; }

        public int ProducerId { get; set; }

        public string Model { get; set; } = string.Empty;

        public bool IsAvailable { get; set; } = true;

        public decimal Price { get; set; }

        public int ProductionYear { get; set; }

        public int SizeWidth { get; set; }

        public int SizeProfile { get; set; }

        public int SizeDiameter { get; set; }

        public bool IsDeleted { get; set; } = false;

        public TyresType TyresType { get; set; }

        public List<OrderTyre> OrderTyres { get; set; } = new List<OrderTyre>();

    }
}
