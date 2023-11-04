namespace EntityLayer.WebApplication.ViewModels.Service
{
    public class ServiceListVM
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; } = null!;
        public string? UpdatedDate { get; set; }

        public string Name { get; set; } = null!;
    }
}
