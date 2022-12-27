using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Controllers
{
    public class BilgiController : Controller
    {
        private readonly SiteContext c;
        public BilgiController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult BilgiIndex()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult BilgiIndex(string ad, string soyad, string konu, string mesaj)
        {
            Iletisim x = new Iletisim();
            x.Ad = ad;
            x.Soyad = soyad;
            x.Konu = konu;
            x.Mesaj = mesaj;
            c.Set<Iletisim>().Add(x);
            c.SaveChanges();
            TempData["success"] = "Fikirlerinizi Bizimle Paylaştığınız İçin Teşekkür Ederiz";
            return RedirectToAction("BilgiIndex","Bilgi");

        }
    }
}
