using EntityLayer.WebApplication.ViewModels.AboutVM;
using EntityLayer.WebApplication.ViewModels.Category;

namespace ServiceLayer.Services.Abstract
{
    public interface ICategoryService
    {
        Task<List<CategoryListVM>> GetAllListAsync();
        Task AddCategoryAsync(CategoryAddVM request);
        Task DeleteCategoryAsync(int id);
        Task<CategoryUpdateVM> GetCategoryById(int id);
        Task UpdateCategoryAsync(CategoryUpdateVM request);
    }
}
