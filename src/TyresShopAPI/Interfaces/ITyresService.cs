using TyresShopAPI.Models;

namespace TyresShopAPI.Interfaces
{
    public interface ITyresService
    {
        public Task AddTyre(TyreCreate tyreCreate);

        public Task UpdateTyre(TyreCreate tyreCreate, int tyreId);

        public Task DeleteTyre(int tyreId);

        public Task<Tyre> GetTyre(int tyreId);
    }
}
