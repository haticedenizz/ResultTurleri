using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15032022_ResultTurleri.Controllers
{
    public class Home6Controller : Controller
    {
        // GET: Home6
        public ActionResult Sayfamiz()
        {
            return View();
        }

        public JavaScriptResult Mesaj()
        {
            string js = "alert('Merhaba action');";
            return JavaScript(js);
        }

        public JavaScriptResult jsButtonOlayi()
        {
            string js = "function button_click() " +
                "{ alert('Merhaba buton'); }    ";
            return JavaScript(js);
        }
    }
}