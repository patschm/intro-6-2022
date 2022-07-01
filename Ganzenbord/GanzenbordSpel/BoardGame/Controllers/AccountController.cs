using BoardGame.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BoardGame.Controllers
{
    public class AccountController : Controller
    {
        // Lack the database. Quick and dirty solution
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
                model = new PlayerModel { Id = Guid.NewGuid().ToString(), Name = model.Name };
                _players.Add(model);
            }
                    
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, model.Id),
                new Claim(ClaimTypes.Name, model.Name)
            };

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = true });
            return RedirectToAction("Index", "Home");
        }
    }
}
