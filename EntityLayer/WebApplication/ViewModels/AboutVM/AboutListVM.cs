using EntityLayer.WebApplication.ViewModels.SocialMedia;
using Microsoft.AspNetCore.Http;

namespace EntityLayer.WebApplication.ViewModels.AboutVM
{
    public class AboutListVM
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdatedDate { get; set; }


        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Clients { get; set; }
        public int Projects { get; set; }
        public int HoursOfSupport { get; set; }
        public int HardWorkers { get; set; }
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;

        public int SocialMediaId { get; set; }
        public SocialMediaListVM SocialMedia { get; set; } = null!;
    }
}
