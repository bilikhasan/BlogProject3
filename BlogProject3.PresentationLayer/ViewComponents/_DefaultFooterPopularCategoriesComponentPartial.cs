using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultFooterPopularCategoriesComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultFooterPopularCategoriesComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TPopularCategories();
            return View(values);
        }
    }
}
