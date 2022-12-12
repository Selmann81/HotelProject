using HotelProject.Models;
using HotelProject.ViewModels.Site;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.ViewComponents.HomePage
{
   
    public class Anasayfa : ViewComponent
    {
        private readonly SiteContext c;
        public Anasayfa(SiteContext c)
        {
            this.c = c;
        }
        public IViewComponentResult Invoke()
        {
            HomeIndexVM mailViewModel = new HomeIndexVM();
            mailViewModel.OdaTips = c.OdaTips.Where(x => x.Act != 0).ToList();
            mailViewModel.Pansiyonlars = c.Pansiyonlars.Where(x => x.Act != 0).ToList();
            return View(mailViewModel);
        }
    }
}
