using TyresShopAPI.Models;

namespace TyresShopAPI.Interfaces
{
    public interface ITyresService
    {
        public Task AddTyre(TyreCreate tyreCreate);

    }
}
