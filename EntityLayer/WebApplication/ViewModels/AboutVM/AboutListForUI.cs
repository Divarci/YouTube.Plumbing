using EntityLayer.WebApplication.ViewModels.SocialMedia;

namespace EntityLayer.WebApplication.ViewModels.AboutVM
{
    public class AboutListForUI
    {        
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Clients { get; set; }
        public int Projects { get; set; }
        public int HoursOfSupport { get; set; }
        public int HardWorkers { get; set; }
        public string FileName { get; set; } = null!;

        public SocialMediaListVM SocialMedia { get; set; } = null!;
    }
}
