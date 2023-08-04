using TyresShopAPI.Entities;

namespace TyresShopAPI.Models
{
    public class TyreView : BaseModel
    {
        public string ProducerName { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int ProductionYear { get; set; }

        public string TyresTypeName { get; set; } = string.Empty;
    }
}
