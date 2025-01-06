using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.BusinessLayer.Concrete;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace BlogProject3.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly INewsletterService _newsletterService;
        private readonly ICommentService _commentService;
        public ArticleController(IArticleService articleService, ICategoryService categoryService, INewsletterService newsletterService, ICommentService commentService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _newsletterService = newsletterService;
            _commentService = commentService;
        }






        public IActionResult ArticleList()
        {
            var values = _articleService.TArticleListWithCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateArticle()
        {
            var categoryList = _categoryService.TGettAll();

            List<SelectListItem> values1 = (from x in categoryList
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();

            ViewBag.v1 = values1;
            return View();
        }
        [HttpPost]
        public IActionResult CreateArticle(Article article)
        {
            article.CreatedDate = DateTime.Now;
            _articleService.TInsert(article);
            return RedirectToAction("ArticleList");
        }
        public IActionResult DeleteArticle(int id)
        {
            _articleService.TDelete(id);
            return RedirectToAction("ArticleList");
        }

        public IActionResult ArticleDetail(int id)
        {
            _articleService.TArticleViewCountIncrease(id);                                  //Önce arttırma işlemi
            var value = _articleService.TArticleListWithCategoryAndAppUserByArticleId(id);  //Sonra Article'ı getirecek.
            return View(value);
        }

        [HttpGet]
        public IActionResult SubscribeNewsletter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubscribeNewsletter(Newsletter newsletter)
        {
            _newsletterService.TInsert(newsletter);
            return RedirectToAction("Index","Default");
        }



    }
}
