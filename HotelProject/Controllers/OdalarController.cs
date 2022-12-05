using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Controllers
{
    public class OdalarController : Controller
    {
        
        public IActionResult Oda()
        {
            return View();
        }
        public IActionResult OdaDetay()
        {
            return View();
        }
    }
}
