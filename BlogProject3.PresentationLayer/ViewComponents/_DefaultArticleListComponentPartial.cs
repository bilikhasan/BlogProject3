using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using X.PagedList.Extensions;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultArticleListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;
        public _DefaultArticleListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke(int page =1)
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser().ToPagedList(page,2);
            return View(values);
        }
    }
}
