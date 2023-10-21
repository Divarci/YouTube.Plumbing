using Microsoft.AspNetCore.Http;

namespace EntityLayer.Identity.ViewModels
{
    public class UserEditVM
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string Password { get; set; } = null!;
        public string? NewPassword { get; set; }
        public string? ConfirmNewPassword { get; set; }


        public string? FileName { get; set; } 
        public string? FileType { get; set; } 

        public IFormFile? Photo { get; set; }

        public string ConcurrencyStamp { get; set; } = null!;

    }
}
