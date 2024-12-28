using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial:ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;
        public _DefaultSocialMediaComponentPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGettAll();
            return View(values);
        }
    }
}
