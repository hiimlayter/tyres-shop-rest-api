using TyresShopAPI.Entities;
using TyresShopAPI.Models;

namespace TyresShopAPI.Interfaces
{
    public interface ITyresService
    {
        public Task AddOrUpdateTyre(TyreCreate tyreCreate);

        public Task<IEnumerable<TyreView>> GetAllTyres();

        public Task<TyreView> GetTyreBydId(int tyreId);

        public Task DeleteTyreById(int id);

        public Task UpdateTyre(TyreCreate tyreCreate, int tyreId);

        public Task DeleteTyre(int tyreId);

        public Task<Tyre> GetTyre(int tyreId);
    }
}
