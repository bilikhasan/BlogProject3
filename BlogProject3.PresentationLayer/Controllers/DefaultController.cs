using BlogProject3.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using PagedList.Mvc;


namespace BlogProject3.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            //var context = new BlogContext();
            //var value = context.Articles.ToList();
            //return View(value);

            return View();
        }
    }
}
