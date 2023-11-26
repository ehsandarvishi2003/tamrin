using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using tamrin.DbContex;
using tamrin.DTOs;
using tamrin.Security;

namespace tamrin.Controllers
{
    public class LoginController : Controller
    {

        #region Contex
        private readonly TamrinDbContex _contex;

        public LoginController(TamrinDbContex contex)
        {
            _contex = contex;
        }
        #endregion

        #region LoginView
        public IActionResult LoginView()
        {
            return View();
        }
        #endregion

        #region LoginAction
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginDTO model)
        {
            if (ModelState.IsValid)
            {
                //1. پیدا کردن اطلاعات کاربری از دیتابیس
                //2. برای کاربر کوکی ست کنیم

                #region Find User From Data Base 

                var user = _contex.Users
                                    .FirstOrDefault(p => p.PhoneNumber == model.PhoneNumber
                                                    &&
                                                    p.Password == PasswordHelper.EncodePasswordMd5(model.Password));

                if (user == null)
                {
                    return NotFound();
                }

                #endregion

                #region Setting Cookie 

                var claims = new List<Claim>
                {
                    new (ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new (ClaimTypes.Name, user.Username),
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(claimIdentity);

                var authProps = new AuthenticationProperties();
                authProps.IsPersistent = model.RememberMe;

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProps);

                return RedirectToAction("Index", "Home");

                #endregion

            }

            return View();
        }
        #endregion
    }
}
