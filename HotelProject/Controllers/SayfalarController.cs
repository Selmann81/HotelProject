using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Controllers
{
    public class SayfalarController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Resimler()
        {
            return View();
        }

        public IActionResult Kolayliklar()
        {
            return View();
        }
    }
}
