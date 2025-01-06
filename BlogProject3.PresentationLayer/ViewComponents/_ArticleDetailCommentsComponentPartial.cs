using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _ArticleDetailCommentsComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;
        public _ArticleDetailCommentsComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke (int id)
        {
            var value = _commentService.TGetCommentsByArticleId(id);
            return View(value);
        }
    }
}
