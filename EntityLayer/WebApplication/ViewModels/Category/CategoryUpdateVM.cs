namespace EntityLayer.WebApplication.ViewModels.Category
{
    public class CategoryUpdateVM
    {
        public int Id { get; set; }
        public string? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; } = null!;

        public string Name { get; set; } = null!;
    }
}
