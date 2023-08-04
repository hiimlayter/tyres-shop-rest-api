using TyresShopAPI.Interfaces;
using TyresShopAPI.Models;
using TyresShopAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace TyresShopAPI.Services
{
    public class TyresService : ITyresService
    {
        private IContext _context;

        public TyresService(IContext context)
        {
            _context = context;
        }

        public async Task AddOrUpdateTyre(TyreCreate model)
        {
            var dbTyre = new Tyre();

            if(model.Id > 0)
            {
                dbTyre = await _context.Tyres.SingleAsync(c => c.Id == model.Id);
            }


            dbTyre.ProducerId = model.ProducerId;
            dbTyre.Price = model.Price;
            dbTyre.TyresType = model.TyresType;
            dbTyre.Model = model.Model;
            dbTyre.ProductionYear = model.ProductionYear;
            dbTyre.SizeProfile = model.SizeProfile;
            dbTyre.SizeWidth = model.SizeWidth;
            dbTyre.SizeDiameter = model.SizeDiameter;

            if(model.Id == 0)
            {
                _context.Tyres.Add(dbTyre);
            }


            await _context.SaveChangesAsync();
        }

        public async Task<TyreView> GetTyreBydId(int tyreId)
        {
            var result = await _context.Tyres
                .Where(x => x.IsAvailable && x.Id == tyreId && !x.IsDeleted)
                .Select(x => new TyreView()
                {
                    Id = x.Id,
                    Model = x.Model,
                    ProducerName = x.Producer.Name,
                    ProductionYear = x.ProductionYear,
                    TyresTypeName = x.TyresType.ToString(),
                    Price = x.Price
                }).SingleOrDefaultAsync();

            if (result == null)
            {
                throw new ArgumentNullException();
            }

            return result;
        }

        public async Task<IEnumerable<TyreView>> GetAllTyres()
        {
            return await _context.Tyres
                .Where(x => x.IsAvailable && !x.IsDeleted)
                .Select(x => new TyreView()
                {
                    Id = x.Id,
                    Model = x.Model,
                    ProducerName = x.Producer.Name,
                    ProductionYear = x.ProductionYear,
                    TyresTypeName = x.TyresType.ToString(),
                    Price = x.Price
                }).ToListAsync();
        }

        public async Task DeleteTyreById(int id)
        {
            var tyre = await _context.Tyres.Where(x => x.Id == id).SingleOrDefaultAsync();

            if (tyre == null)
            {
                throw new ArgumentNullException();
            }

            tyre.IsDeleted = true;

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
