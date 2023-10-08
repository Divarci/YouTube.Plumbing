namespace EntityLayer.Identity.ViewModels
{
    public class LogInVM
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool RememberMe { get; set; }

    }
}
