using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _ArticleDetailPopularCategoriesComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        public _ArticleDetailPopularCategoriesComponentPartial(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TPopularCategories();
            return View(values);
        }
    }
}
