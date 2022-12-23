using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    public class RezervasyonController : Controller
    {
        public IActionResult Index()
        {
            var list = c.Rezervasyons.Include(x => x.Musteri).Include(x => x.OdaTip).Include(x => x.Pansiyons).Where(x => x.Act != 0 && x.Act != 3).ToList();
            List<SelectListItem> odalist = (from p in c.Odalars.ToList().Where(p => p.Act == 1).OrderBy(p => p.OdaNo)
                                            select new SelectListItem
                                            {
                                                Text = p.OdaNo + " - " + p.OdaAdi,
                                                Value = p.Idno.ToString()
                                            }).ToList();
            ViewBag.odaListe = odalist;
            return View(list);
        }
    }
}
