using EntityLayer.WebApplication.ViewModels.Category;

namespace EntityLayer.WebApplication.ViewModels.Portfolio
{
    public class PortfolioListVM
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdatedDate { get; set; }

        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;

        public int CategoryId { get; set; }
        public CategoryListVM Category { get; set; } = null!;
    }
}
