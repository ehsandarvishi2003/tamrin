using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using tamrin.DbContex;

namespace tamrin.Controllers
{
    public class FormController : Controller
    {
        private readonly TamrinDbContex _contex;

        public FormController(TamrinDbContex contex)
        {
            _contex = contex;
        }

        public IActionResult FormView()
        {
            return View();
        }

        #region Form
        [HttpPost]
        public ActionResult CarInfo(Entity.CarInfo model) 
        {
            _contex.CarInfos.Add(model);
            _contex.SaveChanges();

            return RedirectToAction("Index", "Home");

            //return RedirectToAction("Index");
        }

        #endregion
    }
}
