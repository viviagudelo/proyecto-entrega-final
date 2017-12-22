using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySmallBusiness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Emprendedor()
        {
            return View();
        }
        public ActionResult Cliente()
        {
            return View();
        }
        [HttpPost]

        public ActionResult RecibirContacto()
        {
            return View("Gracias");
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}