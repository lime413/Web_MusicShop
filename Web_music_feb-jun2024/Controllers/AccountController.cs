using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Security.Claims;
using System;
using Web_music_feb_jun2024.Models;
using Web_music_feb_jun2024.ViewModels;
using Microsoft.AspNetCore.Authentication;

namespace Web_music_feb_jun2024.Controllers
{
    public class AccountController : Controller
    {
        private MusicContext db;
        public AccountController(MusicContext context)
        {
            db = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Nickname,Password")] UserLoginViewModel userView, string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                User? user = db.Users.FirstOrDefault(x => x.Nickname == userView.Nickname && x.Password == userView.Password);
                if (user is null) return Unauthorized(userView);
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Nickname),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                if (returnUrl is not null) return Redirect(returnUrl);
                return RedirectToAction("Home", "Client");
            }
            return View(userView);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Home", "Client");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("Nickname,Email,Password")] UserRegisterViewModel user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(new Models.User(user.Nickname, user.Email, user.Password));
                await db.SaveChangesAsync();
                return RedirectToAction("Login", user);
            }
            return View(user);
        }
    }
}
