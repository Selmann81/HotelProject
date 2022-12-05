using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult AdminAnasayfa()
        {
            return View();
        }
        public IActionResult deneme()
        {
            return View();
        }
    }
}
