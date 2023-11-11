namespace ServiceLayer.Services.WebApplication.Abstract
{
    public interface IDashboardService
    {
        Task<int> GetAllServicesCountAsync();
        Task<int> GetAllTeamsCountAsync();
        Task<int> GetAllTestimonalsCountAsync();
        Task<int> GetAllCategoriesCountAsync();
        Task<int> GetAllPortfoliosCountAsync();
        int GetAllUsersCountAsync();
    }
}
