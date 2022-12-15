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
        public IActionResult Index(DateTime girisTarih, DateTime cikisTarih, string odatip, string pansiyon, string telefon, string yetiskin, string cocuk)
        {
            Musteri musteri = new Musteri();
            var mus = c.Musteris.FirstOrDefault(x => x.Telefon == telefon);
            if (mus != null)
            {
                musteri.Idno = mus.Idno;
            }
            else
            {
                musteri.Telefon = telefon;
                c.Set<Musteri>().Add(musteri);
                c.SaveChanges();
            }
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.MusteriId = musteri.Idno; 
            rezervasyon.OdaId = 1;
            rezervasyon.GirisTarihi = girisTarih;
            rezervasyon.CikisTarihi = cikisTarih;
            rezervasyon.OdaTipId = Convert.ToInt32(odatip);
            rezervasyon.Pansiyon = Convert.ToInt32(pansiyon);
            rezervasyon.Yetiskin = Convert.ToInt32(yetiskin);
            rezervasyon.Cocuk = Convert.ToInt32(cocuk);
            rezervasyon.Act = 1;
            rezervasyon.RandomKey = RandomString(6);
            var odaTip = c.OdaTips.FirstOrDefault(x => x.Idno == Convert.ToInt32(odatip));
            var pansiyons = c.Pansiyonlars.FirstOrDefault(x => x.Idno == Convert.ToInt32(pansiyon));

            c.Set<Rezervasyon>().Add(rezervasyon);
            c.SaveChanges();

            return RedirectToAction("Rezervasyon", "Home", new { id = rezervasyon.Idno, key = rezervasyon.RandomKey });
        }
        public IActionResult Rezervasyon(DateTime girisTarih, DateTime cikisTarih, string odatip, string pansiyon, string telefon, string yetiskin, string cocuk)
        {
            Musteri mus = new Musteri();
            Rezervasyon rez = new Rezervasyon();
            rez.MusteriId = mus.Idno;
            rez.OdaId = 1;
            rez.GirisTarihi = girisTarih;
            return View();
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
