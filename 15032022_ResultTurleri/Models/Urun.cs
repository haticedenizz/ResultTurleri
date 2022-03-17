using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _15032022_ResultTurleri.Models
{
    public class Urun
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
    }
}