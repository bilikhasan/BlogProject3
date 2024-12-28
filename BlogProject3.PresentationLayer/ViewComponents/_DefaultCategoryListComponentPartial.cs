using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultCategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public _DefaultCategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGettAll();
            return View(values);
        }
    }
}
