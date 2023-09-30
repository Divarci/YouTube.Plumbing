namespace EntityLayer.WebApplication.ViewModels.Testimonal
{
    public class TestimonalListVM
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdatedDate { get; set; }

        public string Comment { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
    }
}
