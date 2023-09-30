using EntityLayer.WebApplication.ViewModels.HomePage;

namespace ServiceLayer.Services.Abstract
{
    public interface IHomePageService
    {
        Task<List<HomePageListVM>> GetAllListAsync();
        Task AddHomePageAsync(HomePageAddVM request);
        Task DeleteHomePageAsync(int id);
        Task<HomePageUpdateVM> GetHomePageById(int id);
        Task UpdateHomePageAsync(HomePageUpdateVM request);
    }
}
