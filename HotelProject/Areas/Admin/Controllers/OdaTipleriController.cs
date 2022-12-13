using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OdaTipleriController : Controller
    {
        private readonly SiteContext c;
        public OdaTipleriController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult OdaTipleri()
        {
            var list = c.OdaTips.Where(x => x.Act != 0).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult YeniOdaTipi(int id)
        {
            OdaTip tip = new OdaTip();
            if (id != 0)
                tip = c.OdaTips.SingleOrDefault(x => x.Idno == id && x.Act == 1);

            if (tip != null)
                return View(tip);
            else
                return RedirectToAction("OdaTipleri", "OdaTipleri");
        }
        [HttpPost]
        public IActionResult YeniOdaTipi(OdaTip tip)
        {
            if (tip.Idno == 0)
            {
                
                tip.Act = 1;
                c.Set<OdaTip>().Add(tip);
                c.SaveChanges();
                TempData["success"] = "Oda tipi eklendi";
            }
            else
            {
                var x = c.OdaTips.SingleOrDefault(x => x.Idno == tip.Idno);
                x.Baslik = tip.Baslik;
                x.Ucret = tip.Ucret;
                c.Set<OdaTip>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Oda tipi güncellendi";
            }
            return RedirectToAction("OdaTipleri", "OdaTipleri");
        }
        public IActionResult TipSil(int id)
        {
            if (id != 0)
            {
                var x = c.OdaTips.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<OdaTip>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Oda tipi silindi";
                }
                else
                    TempData["error"] = "Oda tipi bulunamadı";
            }
            else
                TempData["error"] = "Oda Tipi Bulunamadı";
            return RedirectToAction("OdaTipleri", "OdaTipleri");
        }
    }
}
