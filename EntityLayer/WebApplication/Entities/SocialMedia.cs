using CoreLayer.BaseEntities;

namespace EntityLayer.WebApplication.Entities
{
    public class SocialMedia : BaseEntity
    {
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }

        public About About { get; set; } = null!;
    }
}
