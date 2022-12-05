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
    }
}
