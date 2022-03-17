using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15032022_ResultTurleri.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public RedirectResult Index2()
        {
            //return RedirectToAction("Index"); //Aynı controller daki actiona gider. ActionResult döner

            //return Redirect("Kullanici/Index");//Başka bir kontrollerdaki actiona gider.yada herhangi bir sayfaya yönlendirme yapar.
            return Redirect("https://google.com.tr");
        }
    }
}