using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
