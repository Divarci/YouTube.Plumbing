using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Testimonal;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Filters.WebApplication;
using ServiceLayer.Services.WebApplication.Abstract;

namespace YouTube.Plumbing.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonalController : Controller
    {
        private readonly ITestimonalService _testimonalService;
        private readonly IValidator<TestimonalAddVM> _addValidator;
        private readonly IValidator<TestimonalUpdateVM> _updateValidator;

        public TestimonalController(ITestimonalService testimonalService, IValidator<TestimonalAddVM> addValidator, IValidator<TestimonalUpdateVM> updateValidator)
        {
            _testimonalService = testimonalService;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
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
            var validation = await _addValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _testimonalService.AddTestimonalAsync(request);
                return RedirectToAction("GetTestimonalList", "Testimonal", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }

        [ServiceFilter(typeof(GenericNotFoundFilter<Testimonal>))]
        [HttpGet]
        public async Task<IActionResult> UpdateTestimonal(int id)
        {
            var testimonal = await _testimonalService.GetTestimonalById(id);
            return View(testimonal);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonal(TestimonalUpdateVM request)
        {
            var validation = await _updateValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _testimonalService.UpdateTestimonalAsync(request);
                return RedirectToAction("GetTestimonalList", "Testimonal", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> DeleteTestimonal(int id)
        {
            await _testimonalService.DeleteTestimonalAsync(id);
            return RedirectToAction("GetTestimonalList", "Testimonal", new { Area = ("Admin") });

        }
    }
}
