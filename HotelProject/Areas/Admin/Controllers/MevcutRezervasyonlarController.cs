using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MevcutRezervasyonlarController : Controller
    {
        private readonly SiteContext c;
        public MevcutRezervasyonlarController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult MevcutRezervasyonlar()
        {
            {
                var list = c.Rezervasyons.Where(x => x.Act != 0).ToList();
                return View(list);
            }
        }
    }
}
