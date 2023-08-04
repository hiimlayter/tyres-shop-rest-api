using Microsoft.AspNetCore.Identity;

namespace TyresShopAPI.Interfaces
{
    public interface IIdentityService
    {
        public string GenerateToken(IdentityUser user);

    }
}
