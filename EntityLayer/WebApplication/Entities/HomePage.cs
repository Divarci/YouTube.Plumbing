using CoreLayer.BaseEntities;

namespace EntityLayer.WebApplication.Entities
{
    public class HomePage : BaseEntity
    {      
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string VideoLink { get; set; } = null!;


    }
}
