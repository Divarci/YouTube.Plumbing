using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.AboutVM;

namespace EntityLayer.WebApplication.ViewModels.SocialMedia
{
    public class SocialMediaListVM
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; } = null!;
        public string? UpdatedDate { get; set; }

        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }

        public AboutListVM About { get; set; } = null!;
    }
}
