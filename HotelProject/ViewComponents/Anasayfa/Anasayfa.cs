﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.ViewComponents.Anasayfa
{
    public class Anasayfa : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
