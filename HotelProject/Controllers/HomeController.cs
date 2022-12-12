using HotelProject.Models;
using HotelProject.ViewModels.Site;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly SiteContext c;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, SiteContext c)
        {
            _logger = logger;
            this.c = c;
        }

        public IActionResult deneme()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Rezervasyon(string tarih, string odatip, string pansiyon, string telefon, string yetiskin, string cocuk)
        {
            DateTime.Now.ToString("dd/mm/yy");
            Musteri musteri = new Musteri();
            //DateTime suan = DateTime.Now;
            //string[] tarihAralik = tarih.Split("-");
            //string[] tarih1 = tarihAralik;
            //string[] tarih2 = tarihAralik;

            //DateTime baslangic = new DateTime(Convert.ToInt32(tarih1[2]), Convert.ToInt32(tarih1[0]), Convert.ToInt32(tarih1[1]), suan.Hour, suan.Minute, suan.Second);
            //DateTime bitis = new DateTime(Convert.ToInt32(tarih2[2]), Convert.ToInt32(tarih2[0]), Convert.ToInt32(tarih2[1]), suan.Hour, suan.Minute, suan.Second);


            if (musteri != null)
            {
                musteri.Idno = musteri.Idno;
            }
            else
            {
                musteri.Telefon = telefon;
                c.Set<Musteri>().Add(musteri);
                c.SaveChanges();
            }
            HotelProject.ViewModels.Site.Rezervasyonlar rezervasyon = new HotelProject.ViewModels.Site.Rezervasyonlar();
            rezervasyon.MusteriId = musteri.Idno;
            rezervasyon.OdaId = 1;

            rezervasyon.OdaId = Convert.ToInt32(odatip);
            rezervasyon.Pansiyonlar = Convert.ToInt32(pansiyon);
            rezervasyon.Yetiskin = Convert.ToInt32(yetiskin);
            rezervasyon.Cocuk = Convert.ToInt32(cocuk);
            c.Set<HotelProject.ViewModels.Site.Rezervasyonlar>().Add(rezervasyon);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
