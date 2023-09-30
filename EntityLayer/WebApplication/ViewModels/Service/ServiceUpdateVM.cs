namespace EntityLayer.WebApplication.ViewModels.Service
{
    public class ServiceUpdateVM
    {
        public int Id { get; set; }
        public string? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; } = null!;

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Icon { get; set; } = null!;
    }
}
