using EntityLayer.Identity.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace ServiceLayer.Services.Identity.Abstract
{
    public interface IAuthenticationAdminService
    {
        Task<List<UserVM>> GetUserListAsync();
        Task<IdentityResult> ExtendClaimAsync(string username);
    }
}
