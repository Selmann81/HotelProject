using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MevcutRezervasyonlarController : Controller
    {
        public IActionResult MevcutRezervasyonlar()
        {
            return View();
        }
    }
}
