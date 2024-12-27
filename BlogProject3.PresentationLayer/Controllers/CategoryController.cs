using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace BlogProject3.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGettAll();
            return View(values);
        }

    }
}
