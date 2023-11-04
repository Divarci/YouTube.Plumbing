namespace EntityLayer.WebApplication.ViewModels.HomePage
{
    public class HomePageListVM
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; } = null!;
        public string? UpdatedDate { get; set; }

        public string Header { get; set; } = null!;
        public string VideoLink { get; set; } = null!;
    }
}
