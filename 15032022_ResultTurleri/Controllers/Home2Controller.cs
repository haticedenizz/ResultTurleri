using _15032022_ResultTurleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15032022_ResultTurleri.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Index2()
        {
            Urun u = new Urun();
            u.ID = 1;
            u.Adi = "Bilgisayar";
            u.Fiyat = 15000;
            u.Aciklama = "Asus Laptop";
       
            return Json(u,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index2(int id)
        {
            return Json(null);
        }
    }
}