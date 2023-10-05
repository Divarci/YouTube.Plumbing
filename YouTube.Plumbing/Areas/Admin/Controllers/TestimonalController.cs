using EntityLayer.WebApplication.ViewModels.Testimonal;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApplication.Abstract;

namespace YouTube.Plumbing.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonalController : Controller
    {
        private readonly ITestimonalService _testimonalService;

        public TestimonalController(ITestimonalService testimonalService)
        {
            _testimonalService = testimonalService;
        }

        public async Task<IActionResult> GetTestimonalList()
        {
            var testimonalList = await _testimonalService.GetAllListAsync();
            return View(testimonalList);
        }

        [HttpGet]
        public IActionResult AddTestimonal()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTestimonal(TestimonalAddVM request)
        {
            await _testimonalService.AddTestimonalAsync(request);
            return RedirectToAction("GetTestimonalList", "Testimonal", new { Area = ("Admin") });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonal(int id)
        {
            var testimonal = await _testimonalService.GetTestimonalById(id);
            return View(testimonal);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonal(TestimonalUpdateVM request)
        {
            await _testimonalService.UpdateTestimonalAsync(request);
            return RedirectToAction("GetTestimonalList", "Testimonal", new { Area = ("Admin") });
        }

        public async Task<IActionResult> DeleteTestimonal(int id)
        {
            await _testimonalService.DeleteTestimonalAsync(id);
            return RedirectToAction("GetTestimonalList", "Testimonal", new { Area = ("Admin") });

        }
    }
}
