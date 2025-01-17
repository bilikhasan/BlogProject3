﻿using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Context;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using X.PagedList;
using X.PagedList.Extensions;
using X.PagedList.Mvc.Core;

namespace BlogProject3.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
private readonly IArticleService _articleService;

        public DefaultController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index(int page =1)
        {
            var value = _articleService.TArticleListWithCategoryAndAppUser().ToPagedList(page, 2);
            return View(value);




        }
    }
}
