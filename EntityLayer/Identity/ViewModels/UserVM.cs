using System.Security.Claims;

namespace EntityLayer.Identity.ViewModels
{
    public class UserVM
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public IList<string> UserRoles { get; set; } = null!;
        public IList<Claim>? UserClaims { get; set; }
    }
}
