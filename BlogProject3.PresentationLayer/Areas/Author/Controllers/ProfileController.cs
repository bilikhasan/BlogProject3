using BlogProject3.EntityLayer.Concrete;
using BlogProject3.PresentationLayer.Areas.Author.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject3.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> EditMyProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);      //Giriş Yapan kullanıcının adını yakaladık.
            UserEditViewModel model = new UserEditViewModel();
            model.Surname = values.Surname;
            model.Name = values.Name;
            model.Username = values.UserName;
            model.Email = values.Email;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditMyProfile(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);   //Giriş Yapan kullanıcının adını yakaladık.
            user.Name = model.Name;
            user.Surname = model.Surname;
            user.Email = model.Email;
            user.UserName = model.Username;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("CategoryList", "Category"/*, new { Area ="AreaAdı"}*/ );
            }
            return View();
        }
    }
}
