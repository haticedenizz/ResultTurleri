using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15032022_ResultTurleri.Controllers
{
    public class Home3Controller : Controller
    {
        // GET: Home3
        public ActionResult AnaSayfa()
        {
            ViewBag.liste = veriler;
            return View();
        }

        static List<string> veriler = new List<string>();

        [HttpPost]
        public ActionResult AnaSayfa(string ad,string soyad)
        {
            veriler.Add(ad+" "+soyad);

            // /Home3/Anasayfa?kod=FEC0CEF4-1152-4125-BA94-3F7BFBFFC5DE           

            return new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new
            {
                action = "Anasayfa",
                controller = "Home3",
                kod = Guid.NewGuid().ToString()
            }));
        }
    }
}