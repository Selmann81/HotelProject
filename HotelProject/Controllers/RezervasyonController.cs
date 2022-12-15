using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Controllers
{
    public class RezervasyonController : Controller
    {
        private readonly SiteContext c;
        private readonly ILogger<HomeController> _logger;

        public RezervasyonController(ILogger<HomeController> logger, SiteContext c)
        {
            _logger = logger;
            this.c = c;
        }
        public IActionResult Rezervasyonn(int OdaTipId,DateTime cıkısTarihi)
        {
            //var list = c.Rezervasyons.Include(x => x.Idno).Where(x => x.Act != 0).ToList();
            //Musteri musteri = new Musteri();
            //Rezervasyon rz = new Rezervasyon();
            //list.Oda
            return View();
        }
    }
}
