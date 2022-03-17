using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15032022_ResultTurleri.Controllers
{
    public class Home5Controller : Controller
    {
        // GET: Home5
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult KategorileriGetir()
        {
            return PartialView("_KategorilerPartial");
        }

        public PartialViewResult KategorileriGetir2()
        {
            List<string> kategoriler = new List<string>()
            {
                 "Gıda","Giyim",
                 "Temizlik","Teknoloji"
            };

            return PartialView("_KategorilerPartial2",kategoriler);
        }

    }
}