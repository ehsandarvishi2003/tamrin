using Microsoft.AspNetCore.Mvc;
using tamrin.DbContex;

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
        public ActionResult LoginView()
        {
            return View();
        }
        #endregion

        #region LoginAction
        [HttpPost]
        public ActionResult Login()
        {
            return RedirectToAction("Index");
        }
        #endregion
    }
}
