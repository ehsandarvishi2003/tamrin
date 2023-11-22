using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using tamrin.DbContex;

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

        #region RegisterAction
        [HttpPost]
        public ActionResult Registerr(Entity.User user)
        {
            _contex.Users.Add(user);
            _contex.SaveChanges();

            //return RedirectToAction("Home");
            return View();
            //return RedirectToActionResult RedirectToAction("Index" , "HomeController", "View");

        }
        #endregion
    }
}
