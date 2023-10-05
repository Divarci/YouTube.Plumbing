using Microsoft.AspNetCore.Http;

namespace EntityLayer.WebApplication.ViewModels.Team
{
    public class TeamUpdateVM
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; } = null!;


        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }

        public IFormFile Photo { get; set; } = null!;
    }
}
