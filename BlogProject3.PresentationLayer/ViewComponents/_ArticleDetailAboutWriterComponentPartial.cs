using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _ArticleDetailAboutWriterComponentPartial  :ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleDetailAboutWriterComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
