using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultNewsletterComponentPartial : ViewComponent
    {
        private readonly INewsletterService _newsletterService;

        public _DefaultNewsletterComponentPartial(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }
        public IViewComponentResult Invoke()
        {
            var values = new Newsletter();
            return View(values);
        }
    }
}




