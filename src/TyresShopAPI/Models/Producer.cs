namespace TyresShopAPI.Models
{
    public class Producer : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public string Localization { get; set; } = string.Empty;

        public List<Tyre> Tyres { get; set; } = new List<Tyre> { };

    }
}
