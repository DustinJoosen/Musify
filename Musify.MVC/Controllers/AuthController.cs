using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Musify.MVC.Data;
using Musify.MVC.Models;
using System.Security.Claims;
using Musify.MVC.Dtos;
using Microsoft.EntityFrameworkCore;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace Musify.MVC.Controllers
{
    public class AuthController : Controller
    {
        private ApplicationDbContext _context;
        private INotyfService _notyf;

        public AuthController(ApplicationDbContext context, INotyfService notyf)
        {
            this._context = context;
            this._notyf = notyf;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AuthDto auth, bool showNotyf=true)
        {
            if (!ModelState.IsValid)
            {
                return View(auth);
            }

            // Validation.
            if (!(_context.Users.Select(u => u.Username).Contains(auth.Username)))
            {
                ModelState.AddModelError("Username", "Username is not used");
                return View(auth);
            }

            // Getting attempted user.
            var user = await this._context.Users.SingleOrDefaultAsync(user => user.Username == auth.Username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(auth.Password, user.Password))
            {
                ModelState.AddModelError("Password", "Password is incorrect");
                return View(auth);
            }

            // Sign in using httpcontext
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Id.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var props = new AuthenticationProperties()
            {
                ExpiresUtc = DateTime.UtcNow.AddDays(7),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
            
            if (showNotyf)
            {
                this._notyf.Information($"Successfully signed in. Welcome {user.Name}");
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            // Validation.
            if (_context.Users.Select(u => u.Username).Contains(register.Username))
            {
                ModelState.AddModelError(nameof(register.Username), "This username is already in use");
                return View(register);
            }

            if (register.PasswordConfirmation != register.Password)
            {
                ModelState.AddModelError("PasswordConfirmation", "Passwords don't match");
                return View(register);
            }

            // Account creation.
            var user = new User
            {
                Name = register.Name,
                Username = register.Username,
                BirthDate = register.BirthDate,
                Password = BCrypt.Net.BCrypt.HashPassword(register.Password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            _notyf.Information($"Successfully registered your account. Welcome {user.Name}.");

            // Log in using the new account.
            return await Login(new()
            {
                Username = register.Username,
                Password = register.Password
            }, showNotyf: false);
        }
    }
}
