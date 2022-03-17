using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _15032022_ResultTurleri.Controllers
{
    public class Home4Controller : Controller
    {
        // GET: Home4
        public ActionResult Dosyalar()
        {
            return View();
        }

        public FileResult PDFGoster()
        {
            string dosyayolu = Server.MapPath("~/File/deneme.pdf");
            return new FilePathResult(dosyayolu,"application/pdf");
        }

       
        public FileStreamResult DosyaIndir()
        {
            string metin = "Bu bir deneme dosyasıdır";

            MemoryStream memo = new MemoryStream(); //Hafızada oluşan dosya

            byte[] byt = Encoding.UTF8.GetBytes(metin);//hafızada oluşacak dosya içine byte dizi yazılabileceğinden metini dönüştürdük.

            memo.Write(byt, 0, byt.Length);
            memo.Position = 0;

            FileStreamResult result = new FileStreamResult(memo, "text/plain");

            result.FileDownloadName = "deneme.txt";

            return result;
        }

    }
}