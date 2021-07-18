using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Electricad.Data;
using Electricad.Areas.Identity.Repository;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Electricad.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AccountController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IWorkContent _workContent;
       
        public AccountController(IWorkContent workContent)
        {
            _workContent = workContent;
            //_context = context;
        }

        // GET: Login

        
        [HttpGet]
        public IActionResult Logintest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logintest(User user)
        {
            if (ModelState.IsValid) { 
                if ((user.login.ToLower() == "admin@admin") && (user.password == "admin"))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.login)
                    };
                    var identity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var props = new AuthenticationProperties();
                    HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
                    return RedirectToAction("Index","Offers");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

