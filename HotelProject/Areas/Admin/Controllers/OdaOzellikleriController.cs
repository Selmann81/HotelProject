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
    }
}
