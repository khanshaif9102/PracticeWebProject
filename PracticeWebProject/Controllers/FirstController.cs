using Microsoft.AspNetCore.Mvc;

namespace PracticeWebProject.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
