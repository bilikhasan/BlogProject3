using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultRecentPostsListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;
        public _DefaultRecentPostsListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TLastThreeArticles();
            return View(values);
        }
    }
}
