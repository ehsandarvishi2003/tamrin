using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using tamrin.DbContex;
using tamrin.DTOs;
using tamrin.Entity;

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
        public ActionResult Registering(UserRegisterDTO userDTO)
        {
            if(ModelState.IsValid)
            {
                //Object Maping
                User user = new User()
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    PhoneNumber = userDTO.PhoneNumber,
                    Password = userDTO.Password,
                };

                //Add User To Data Base
                _contex.Users.Add(user);
                _contex.SaveChanges();
                //After add go Home View
                return RedirectToAction("Index","Home");
            }
            //else go Register View
            return View();
        }
        #endregion

    }
}
