using CoreLayer.BaseEntities;

namespace EntityLayer.WebApplication.Entities
{
    public class Contact : BaseEntity
    {
        public string Location { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Call { get; set; } = null!;
        public string Map { get; set; } = null!;
    }
}
