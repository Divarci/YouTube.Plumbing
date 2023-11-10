using Microsoft.AspNetCore.Mvc;

namespace YouTube.Plumbing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}