using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebUI.Models;
using WebUI.ViewModels.Account;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager { get; set; }
        private SignInManager<AppUser> _signInManager { get; set; }
        public AccountController(UserManager<AppUser>  userManager, 
                               SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        // GET: AccountController
        public IActionResult Register()
        {
            return View();
        }

        // GET: AccountController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }


        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterCreateVM user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            AppUser newUser = new AppUser
            {
                UserName=user.Username,
                Fullname = user.Fullname,
                Email = user.Email,
            };
            var identityResult = await _userManager.CreateAsync(newUser,user.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(user);
            }
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index","Home");
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
