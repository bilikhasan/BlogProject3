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

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        public async Task <IActionResult> MyCommentList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _commentService.TGetCommentsByAppUserId(user.Id);
            return View(values);
        }
    }
}
