using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class DashboardController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;
        private readonly ICategoryService _categoryService;
        private readonly INewsletterService _newsletterService;
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(IArticleService articleService, ICommentService commentService, ICategoryService categoryService, INewsletterService newsletterService, UserManager<AppUser> userManager)
        {
            _articleService = articleService;
            _commentService = commentService;
            _categoryService = categoryService;
            _newsletterService = newsletterService;
            _userManager = userManager;
        }

        public async Task<IActionResult> DashboardIndex()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var totalCategories = _categoryService.TPopularCategories().Count().ToString();
            ViewBag.TotalCategories = totalCategories;

            var myArticleCount = _articleService.TGetArticlesByAppUserId(user.Id).Count().ToString();
            ViewBag.ArticleCount = myArticleCount;

            var myCommentCount = _commentService.TGetCommentsByAppUserId(user.Id).Count().ToString();
            ViewBag.CommentCount = myCommentCount;

            var totalArticleCount = _articleService.TGettAll().Count().ToString();
            ViewBag.AllArticleCount = totalArticleCount;



            return View();
        }
    }
}
