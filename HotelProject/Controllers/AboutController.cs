using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Controllers
{
    public class AboutController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekip()
        {
            return View();
        }
        public IActionResult Referans()
        {
            return View();
        }
        public IActionResult SSS()
        {
            return View();
        }
    }
}
