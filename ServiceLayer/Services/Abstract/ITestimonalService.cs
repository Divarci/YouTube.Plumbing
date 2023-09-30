using EntityLayer.WebApplication.ViewModels.Team;
using EntityLayer.WebApplication.ViewModels.Testimonal;

namespace ServiceLayer.Services.Abstract
{
    public interface ITestimonalService
    {
        Task<List<TestimonalListVM>> GetAllListAsync();
        Task AddTestimonalAsync(TestimonalAddVM request);
        Task DeleteTestimonalAsync(int id);
        Task<TestimonalUpdateVM> GetTestimonalById(int id);
        Task UpdateTestimonalAsync(TestimonalUpdateVM request);
    }
}
