using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager, IArticleService articleService)
        {
            _commentService = commentService;
            _userManager = userManager;
            _articleService = articleService;
        }

        public async Task<IActionResult> MyCommentList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _commentService.TGetCommentsByAppUserId(user.Id);
            return View(values);
        }

        public async Task<IActionResult> CommentDelete(int id)
        {
            _commentService.TDelete(id);
            return RedirectToAction("MyCommentList");
        }


        [HttpGet]
        public IActionResult CommentUpdate(int id)
        {
            var value = _commentService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> CommentUpdate(Comment comment)
        {
            ModelState.Clear();

            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            comment.AppUserId = values.Id;
            comment.CreatedDate = DateTime.Now;
            comment.Status = true;
            comment.ArticleId = values.Id;
            comment.CommentId = values.Id;

            _commentService.TUpdate(comment);
            return RedirectToAction("MyCommentList");
        }
    }
}
