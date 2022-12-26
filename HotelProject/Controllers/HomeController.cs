using HotelProject.Models;
using HotelProject.ViewModels.Site;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            string girisZamani = Convert.ToString(girisTarih);
            string cikisZamani = Convert.ToString(cikisTarih);
            TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
            string gunfarki = girisCikisFarki.ToString();

            Rezervasyon rezervasyons = new Rezervasyon();
            rezervasyons.MusteriId = musteri.Idno;
            rezervasyons.OdaId = 1;
            rezervasyons.GirisTarihi = girisTarih;
            rezervasyons.CikisTarihi = cikisTarih;
            rezervasyons.OdaTipId = Convert.ToInt32(odatip);
            rezervasyons.Pansiyon = Convert.ToInt32(pansiyon);
            rezervasyons.Yetiskin = Convert.ToInt32(yetiskin);
            rezervasyons.Cocuk = Convert.ToInt32(cocuk);
            rezervasyons.Act = 1;
            rezervasyons.RandomKey = RandomString(6);
            var odaTip = c.OdaTips.FirstOrDefault(x => x.Idno == Convert.ToInt32(odatip));
            var pansiyonlars = c.Pansiyonlars.FirstOrDefault(x => x.Idno == Convert.ToInt32(pansiyon));
            var yaricocuk = Convert.ToInt32(cocuk) / 2;
            double ucret = ((odaTip.Ucret) + (pansiyonlars.Ucret));
            rezervasyons.Ucret = (girisCikisFarki.TotalDays * ucret) * ((Convert.ToInt32(yetiskin)) + (Convert.ToInt32(yaricocuk)));

            c.Set<Rezervasyon>().Add(rezervasyons);
            c.SaveChanges();

            return RedirectToAction("Rezervasyon", "Home", new { id = rezervasyons.Idno, key = rezervasyons.RandomKey });
        }
        public IActionResult Rezervasyon(int id, string key/*, int onay*/)
        {
            //VERİ TABANINDA Idno ve random keyi eşitse devam eder ve rez in içine atar tek veriyi alır ilk çıkan sorguyu 

            var rez = c.Rezervasyons.FirstOrDefault(x => x.Idno == id && x.RandomKey == key /*&& x.Act==onay*/);



            if (rez != null)
            {
                return View(rez);
            }
            else
                return RedirectToAction("Index", "Home");

        }
        public IActionResult RezervasyonOnay(int id,string key)
        {
            var rez = c.Rezervasyons.FirstOrDefault(x => x.Idno == id && x.RandomKey==key);
            if (rez==null)
            {
                TempData["success"] = "Rezervasyon Başarıyla Oluşturulmuştur";
                return RedirectToAction("Index", "Home");
            }
            rez.Act = 1;
            c.Set<Rezervasyon>().Update(rez);
            c.SaveChanges();
            TempData["success"] = "Rezervasyon Başarıyla Oluşturulmuştur";
            return RedirectToAction("Index", "Home");
        }
        public IActionResult RezervasyonIptal(int id,string key)
        {
            var rez = c.Rezervasyons.FirstOrDefault(x => x.Idno == id && x.RandomKey == key);
            if (rez == null)
            {
                TempData["success"] = "Rezervasyon Başarıyla İptal Edilmiştir";
                return RedirectToAction("Index", "Home");
            }
            rez.Act = 0;
            c.Set<Rezervasyon>().Update(rez);
            c.SaveChanges();
            TempData["success"] = "Rezervasyon Başarıyla İptal Edilmiştir";
            return RedirectToAction("Index", "Home");
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
