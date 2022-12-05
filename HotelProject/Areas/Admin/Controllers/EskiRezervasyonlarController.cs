using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EskiRezervasyonlarController : Controller
    {
        public IActionResult EskiRezervasyonlar()
        {
            return View();
        }
    }
}
