namespace EntityLayer.WebApplication.ViewModels.Team
{
    public class TeamUpdateVM
    {
        public int Id { get; set; }
        public string? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; } = null!;
    }
}
