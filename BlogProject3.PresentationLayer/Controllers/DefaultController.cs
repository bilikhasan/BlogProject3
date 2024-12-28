using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
