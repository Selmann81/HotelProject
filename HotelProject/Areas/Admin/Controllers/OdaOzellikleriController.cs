using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OdaOzellikleriController : Controller
    {
        private readonly SiteContext c;
        public OdaOzellikleriController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult OdaOzellikleri()
        {
            var list = c.OdaOzelliks.Where(x => x.Act != 0).ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult YeniOzellik(int id)
        {
            OdaOzellik ozellik = new OdaOzellik();
            if (id != 0)
                ozellik = c.OdaOzelliks.SingleOrDefault(x => x.Idno == id && x.Act == 1);

            if (ozellik != null)
                return View(ozellik);
            else
                return RedirectToAction("OdaOzellik", "Odalar");
        }
        [HttpPost]
        public IActionResult YeniOzellik(OdaOzellik ozellik)
        {
            if (ozellik.Idno == 0)
            {
                ozellik.Act = 1;
                c.Set<OdaOzellik>().Add(ozellik);
                c.SaveChanges();
                TempData["success"] = "Oda özelliği eklendi";
            }
            else
            {
                var x = c.OdaOzelliks.SingleOrDefault(x => x.Idno == ozellik.Idno);
                x.Baslik = ozellik.Baslik;
                x.Ikon = ozellik.Ikon;
                c.Set<OdaOzellik>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Oda özelliği güncellendi";
            }
            return RedirectToAction("OdaOzellik", "Odalar");
        }
    }
}
