using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultFooterPopularPostsComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultFooterPopularPostsComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TPopularArticles();
            return View(values);
        }
    }
}
