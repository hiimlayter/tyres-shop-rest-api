using TyresShopAPI.Interfaces;
using TyresShopAPI.Models;

namespace TyresShopAPI.Services
{
    public class TyresService : ITyresService
    {
        private IContext _context;

        public TyresService(IContext context)
        {
            _context = context;
        }

        public async Task AddTyre(TyreCreate tyreCreate)
        {
            var dbTyre = new Tyre();

            dbTyre.ProducerId = tyreCreate.ProducerId;
            dbTyre.Price = tyreCreate.Price;
            dbTyre.TyresType = tyreCreate.TyresType;
            dbTyre.Model = tyreCreate.Model;
            dbTyre.ProductionYear = tyreCreate.ProductionYear;
            dbTyre.SizeProfile = tyreCreate.SizeProfile;
            dbTyre.SizeWidth = tyreCreate.SizeWidth;
            dbTyre.SizeDiameter = tyreCreate.SizeDiameter;

            _context.Tyres.Add(dbTyre);

            await _context.SaveChangesAsync();
        }
    }
}
