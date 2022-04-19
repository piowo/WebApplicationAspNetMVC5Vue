using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationAspNetMVC5Vue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Oto opis aplikacji";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Oto kontakt z autorem";

            return View();
        }
        public ActionResult Odpowiedz()
        {
            ViewBag.Message = "Wnioski z decyzji";
            return View();
        }
    }
}