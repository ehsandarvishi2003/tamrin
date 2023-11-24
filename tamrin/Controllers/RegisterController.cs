using Microsoft.AspNetCore.Mvc;
using tamrin.DbContex;
using tamrin.DTOs;
using tamrin.Entity;
using tamrin.Security;

namespace tamrin.Controllers
{
    public class RegisterController : Controller
    {
        #region Contex
        private readonly TamrinDbContex _contex;

        public RegisterController(TamrinDbContex contex)
        {
            _contex = contex;
        }
        #endregion

        #region RegisterView
        public IActionResult RegisterView()
        {
            return View();
        }
        #endregion

        #region Register Action

        [HttpPost , ValidateAntiForgeryToken]
        public IActionResult Register(UserRegisterDTO userDTO)
        {
            if(ModelState.IsValid)
            {
                if(_contex.Users.Any(p=>p.PhoneNumber==userDTO.PhoneNumber)==false) { }
                //Object Maping
                User user = new User()
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    PhoneNumber = userDTO.PhoneNumber,
                    Password = PassworHelper.EncodePasswordMd5(userDTO.Password)
                };

                //Add User To Data Base
                _contex.Users.Add(user);
                _contex.SaveChanges();
                //After add go Home View
                return RedirectToAction("Index","Home");
            }
            //else go Register View
            return View(RegisterView);
        }
        #endregion

    }
}
