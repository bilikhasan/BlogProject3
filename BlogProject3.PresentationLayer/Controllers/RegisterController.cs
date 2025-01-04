﻿using BlogProject3.EntityLayer.Concrete;
using BlogProject3.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Email = model.Email,                //Buradaki 5 özelliği appUser Nesnesine atadım.
                Surname = model.Surname,
                UserName = model.Username,
                ImageUrl = "test",
                Description="Örnek Açıklama"
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
    }
}
