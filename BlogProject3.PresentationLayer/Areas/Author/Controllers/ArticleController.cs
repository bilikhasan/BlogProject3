using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogProject3.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly UserManager<AppUser> _userManager;
        private readonly ICategoryService _categoryService;

        public ArticleController(IArticleService articleService, UserManager<AppUser> userManager, ICategoryService categoryService)
        {
            _articleService = articleService;
            _userManager = userManager;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _articleService.TGetArticlesByAppUserId(userValue.Id);
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> ArticleCreate()
        {
            var categoryList = _categoryService.TGettAll();

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ArticleCreate(Article article)
        {
            ModelState.Clear();

            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            article.AppUserId = values.Id;
            article.CreatedDate = DateTime.Now;
            article.ArticleViewCount = 0;
            article.MainImageUrl = "";
            _articleService.TInsert(article);

            return RedirectToAction("Index");
        }

        public IActionResult ArticleDelete(int id)
        {
            _articleService.TDelete(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult ArticleUpdate(int id)
        {
            var value = _articleService.TGetById(id);
            var categoryList = _categoryService.TGettAll();

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.Categories = categories;
            return View(value);
        }
        [HttpPost]
        public IActionResult ArticleUpdate(Article article)
        {
            _articleService.TUpdate(article);
            return RedirectToAction("Index");
        }
    }
}
