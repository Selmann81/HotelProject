using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Controllers
{
    public class İletisimController : Controller
    {
        public IActionResult İletisim()
        {
            return View();
        }
    }
}
