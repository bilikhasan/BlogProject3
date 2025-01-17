﻿using BlogProject3.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.ViewComponents
{
    public class _DefaultCategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;
        public _DefaultCategoryListComponentPartial(ICategoryService categoryService, IArticleService articleService)
        {
            _categoryService = categoryService;
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TArticleCountGroupedByCategory();
            return View(values);
        }
    }
}
