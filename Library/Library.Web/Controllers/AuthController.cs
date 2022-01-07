using Library.Core.DTOs;
using Library.Core.Repositories;
using Library.Domain.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Library.Web.Controllers
{
    public class AuthController : Controller
    {
        private IUserRepository _userRepository;
        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Route("Login")]
        public IActionResult Login(string error)
        {
            if (error == "role")
            {
                ViewData["error"] = "شما به پنل ادمین دسترسی ندارید";
            }
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            var userLogined = await _userRepository.Login(login);
            if (userLogined == null)
            {
                ModelState.AddModelError("FullName", "کاربر گرامی شما فعال نیستید");
                return View(login);
            }

            #region Authentication

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,userLogined.Id.ToString()),
                new Claim(ClaimTypes.Name,userLogined.FullName),
                new Claim(ClaimTypes.Role,userLogined.Role),
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principle = new ClaimsPrincipal(identity);
            var properties = new AuthenticationProperties()
            {
                IsPersistent = login.RemmemberMe
            };

            await HttpContext.SignInAsync(principle, properties);

            #endregion


            return Redirect("/");
        }

        [Route("Logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }

        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
                user.Role = "user";
                await _userRepository.Create(user);
                return RedirectToAction(nameof(Login));
        }
    }
}
