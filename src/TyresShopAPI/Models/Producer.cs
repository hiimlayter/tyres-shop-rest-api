namespace TyresShopAPI.Models
{
    public class Producer : BaseModel
    {
        public string Name { get; set; }

        public string Localization { get; set; }

        public List<Tyres> Tyres { get; set; } = new List<Tyres> { };

        public Producer(string name, string localization)
        {
            Name = name;
            Localization = localization;
        }
    }
}
