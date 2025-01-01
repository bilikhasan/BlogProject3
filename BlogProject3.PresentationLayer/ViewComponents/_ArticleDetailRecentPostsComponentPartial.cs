using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _ArticleDetailRecentPostsComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;
        public _ArticleDetailRecentPostsComponentPartial(IArticleService articleService)
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
