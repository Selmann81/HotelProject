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
    }
}
