using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YeniMusteriController : Controller
    {
        private readonly SiteContext c;
        public YeniMusteriController(SiteContext c)
        {
            this.c = c;
        }
        [HttpGet]
        public IActionResult YeniMusteri(int id)
        {
            Musteri musteri = new Musteri();
            musteri.DogumTarihi = DateTime.Today.AddYears(-20);
            if (id != 0)
            {
                musteri = c.Musteris.SingleOrDefault(X => X.Idno == id);
            }
            return View(musteri);
        }
        [HttpPost]
        public IActionResult YeniMusteri(Musteri m)
        {
            if (m.Idno==0)
            {
                m.Act = 1;
                c.Set<Musteri>().Add(m);
                c.SaveChanges();
                TempData["success"] = "Müşteri Eklendi";
            }
            else
            {
                var x = c.Musteris.SingleOrDefault(x => x.Idno == m.Idno);
                x.Adisoyadi = m.Adisoyadi;
                x.DogumTarihi = m.DogumTarihi;
                x.TcNo = m.TcNo;
                x.Telefon = m.Telefon;
                x.Uyruk = m.Uyruk;
                c.Set<Musteri>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Müşteri güncellendi";
            }
            return RedirectToAction("Musteriler", "Musteriler");
        }
    }
}
