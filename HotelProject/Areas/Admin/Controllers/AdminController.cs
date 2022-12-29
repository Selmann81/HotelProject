using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly SiteContext c;
        public AdminController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult AdminAnasayfa()
        {
            //var count = c.Rezervasyons.GroupBy(x => x.Idno).Select(y => new
            //{
            //    Id = y.Key,
            //    CoutOfusers = y.Count()
            //}).ToList();

            var list = c.Rezervasyons.Where(x => x.Act == 1).Count();
            var list = c.Rezervasyons.Where(x => x.Act == 2).Count();
            var list = c.Rezervasyons.Where(x => x.Act == 3).Count();
           
            return View();
        }
        public IActionResult deneme()
        {
            return View();
        }
        public IActionResult test(int id)
        {
            Odalar odalar = new Odalar();
            
            List<SelectListItem> odalars = (from p in c.Odalars.ToList().Where(p => p.Act == 1 && !String.IsNullOrEmpty(p.OdaAdi)).OrderBy(p => p.OdaAdi)select new SelectListItem
                                                {
                                                Text = p.OdaAdi,
                                                Value = p.Idno.ToString()
                                            }).ToList();
            ViewBag.odaTip = odalars;
            if (id != 0)
            {
                odalar = c.Odalars.SingleOrDefault(x => x.Idno == id);
            }
            return View(odalar);
        }
    }
}
