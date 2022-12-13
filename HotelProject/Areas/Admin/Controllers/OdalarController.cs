using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OdalarController : Controller

    {
        private readonly SiteContext c;
        public OdalarController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult Odalar()
        {
            var list = c.Odalars.Include(x => x.OdaTips).Where(x => x.Act != 0).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult YeniOda(int id)
        {
            Odalar odalar = new Odalar();
            List<SelectListItem> odatips = (from p in c.OdaTips.ToList().Where(p => p.Act == 1 && !String.IsNullOrEmpty(p.Baslik)).OrderBy(p => p.Baslik)
            select new SelectListItem
            {
                Text = p.Baslik,
                Value = p.Idno.ToString()
            }).ToList();

            ViewBag.odaTip = odatips;
            if (id != 0)
            {
                odalar = c.Odalars.SingleOrDefault(x => x.Idno == id);
            }
            return View(odalar);

        }
        [HttpPost]
        public IActionResult YeniOda(Odalar oda)
        {
            if (oda.Idno == 0)
            {
                oda.Act = 1;
                c.Set<Odalar>().Add(oda);
                c.SaveChanges();
                TempData["success"] = "Yeni oda başarıyla eklendi.";
            }
            else
            {
                var x = c.Odalars.SingleOrDefault(x => x.Idno == oda.Idno);
                x.OdaAdi = oda.OdaAdi;
                x.OdaNo = oda.OdaNo;
                x.OdaTip = oda.OdaTip;
                x.YatakSayisi = oda.YatakSayisi;
                x.Cephe = oda.Cephe;
                c.Set<Odalar>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Oda başarıyla güncellendi.";
            }
            return RedirectToAction("Odalar", "Odalar");
        }
        public IActionResult OdaSil(int id)
        {
            if (id != 0)
            {
                var x = c.Odalars.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<Odalar>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Odadan başarıyla silindi";
                }
                else
                    TempData["error"] = "Oda bulunamadı";
            }
            else
                TempData["error"] = "Oda bulunamadı";
            return RedirectToAction("Odalar", "Odalar");
        }
    }
}
