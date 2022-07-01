using BoardGame.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BoardGame.Controllers
{
    public class AccountController : Controller
    {
        private static List<PlayerModel> _players = new List<PlayerModel>();

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(PlayerModel model)
        {
            PlayerModel tmp = _players.FirstOrDefault(p=>p.Name == model.Name);
            if (tmp == null)
            {
                return RedirectToAction("Register");
            }
            
            
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, model.Id),
                new Claim(ClaimTypes.Name, model.Name)
            };

            ClaimsIdentity idenity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal prin = new ClaimsPrincipal(idenity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, prin, new AuthenticationProperties { IsPersistent = true });
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(PlayerModel model)
        {
            model.Id = Guid.NewGuid().ToString();
            _players.Add(model);
            return await Login(model);
        }
    }
}
