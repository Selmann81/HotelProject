using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    public class PansiyonlarController : Controller
    {
        private readonly SiteContext c;
        public PansiyonlarController(SiteContext c)
        {
            this.c = c;
        }
        [Area("Admin")]
        public IActionResult Pansiyonlar()
        {
            var list = c.Pansiyonlars.Where(x => x.Act != 0).ToList();
            return View(list);
        }
        
        [HttpGet]
        public IActionResult YeniPansiyon(int id)
        {
            Pansiyonlar pansiyon = new Pansiyonlar();
            if (id != 0)
                pansiyon = c.Pansiyonlars.SingleOrDefault(x => x.Idno == id && x.Act == 1);

            if (pansiyon != null)
                return View(pansiyon);
            else
                return RedirectToAction("Pansiyonlar", "Pansiyonlar");
        }
        [HttpPost]
        public IActionResult YeniPansiyon(Pansiyonlar pansiyon)
        {

            if (pansiyon.Idno == 0)
            {
                pansiyon.Act = 1;
                c.Set<Pansiyonlar>().Add(pansiyon);
                c.SaveChanges();
                TempData["success"] = "Pansiyon eklendi";
            }
            else
            {
                var x = c.Pansiyonlars.SingleOrDefault(x => x.Idno == pansiyon.Idno);
                x.Baslik = pansiyon.Baslik;
                x.Ucret = pansiyon.Ucret;
                c.Set<Pansiyonlar>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Pansiyon güncellendi";
            }
            return RedirectToAction("Pansiyonlar", "Pansiyonlar");
        }
    }
}
