using EntityLayer.WebApplication.ViewModels.Category;

namespace EntityLayer.WebApplication.ViewModels.Portfolio
{
    public class PortfolioListForUI
    {
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;

        public CategoryListForUI Category { get; set; } = null!;
    }
}
