using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultArticleListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;
        public _DefaultArticleListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }
    }
}
