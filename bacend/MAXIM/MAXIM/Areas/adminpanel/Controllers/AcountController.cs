using MAXIM.Models;
using MAXIM.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAXIM.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class AcountController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public AcountController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();
            AppUser appUser = new AppUser
            {
                FirstName = registerVM.FirstName,
                LastName = registerVM.LastName,
                Email = registerVM.Email,
                UserName = registerVM.UserName
            };

            IdentityResult result = await userManager.CreateAsync(appUser, registerVM.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "a");
                return View();
            }

            return RedirectToAction("Index","Dashboard");
        }
    }
}
