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

        public async Task DeleteTyre(int tyreId)
        {
            var dbTyre = GetTyre(tyreId).Result;
            _context.Tyres.Remove(dbTyre);
            await _context.SaveChangesAsync();
        }

        public async Task<Tyre> GetTyre(int tyreId)
        {
            var dbTyre = await _context.Tyres.FindAsync(tyreId);
            if (dbTyre != null)
            {
                return dbTyre;
            }
            throw new Exception("Nie znaleziono opony o podanym Id");
        }

        public async Task UpdateTyre(TyreCreate tyreCreate, int tyreId)
        {
            var dbTyre = GetTyre(tyreId).Result;

            dbTyre.ProducerId = tyreCreate.ProducerId;
            dbTyre.Price = tyreCreate.Price;
            dbTyre.TyresType = tyreCreate.TyresType;
            dbTyre.Model = tyreCreate.Model;
            dbTyre.ProductionYear = tyreCreate.ProductionYear;
            dbTyre.SizeProfile = tyreCreate.SizeProfile;
            dbTyre.SizeWidth = tyreCreate.SizeWidth;
            dbTyre.SizeDiameter = tyreCreate.SizeDiameter;

            await _context.SaveChangesAsync();
        }
    }
}
