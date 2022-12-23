using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YeniMusteriController : Controller
    {
        private readonly SiteContext c;
        public YeniMusteriController(SiteContext c)
        {
            this.c = c;
        }
        
    }
}
