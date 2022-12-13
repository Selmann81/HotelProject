using HotelProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MusterilerController : Controller
    {
        private readonly SiteContext c;
        public MusterilerController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult Musteriler()
        {
            var list = c.Musteris.Where(x => x.Act != 0).ToList();
            return View(list);
        }

    }
}

    

