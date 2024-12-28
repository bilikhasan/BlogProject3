using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultHeadComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
