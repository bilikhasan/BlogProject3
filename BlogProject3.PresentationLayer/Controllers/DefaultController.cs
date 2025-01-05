using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Context;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;


namespace BlogProject3.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
private readonly IArticleService _articleService;

        public DefaultController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            var context = new BlogContext();
            var value = context.Articles.OrderByDescending(x=>x.CreatedDate).ToList();
            return View(value);




        }
    }
}
