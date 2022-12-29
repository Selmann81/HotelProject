using HotelProject.Models;
using HotelProject.ViewModels.Site;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RezervasyonController : Controller
    {
        private readonly SiteContext c;
        public RezervasyonController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult Index()
        {
            var list = c.Rezervasyons.Include(x => x.Musteri).Include(x => x.OdaTip).Include(x => x.Pansiyonlars).Where(x => x.Act != 0 && x.Act != 3).ToList();
            List<SelectListItem> odalist = (from p in c.Odalars.ToList().Where(p => p.Act == 1).OrderBy(p => p.OdaNo)
                                            select new SelectListItem
                                            {
                                                Text = p.OdaNo + " - " + p.OdaAdi,
                                                Value = p.Idno.ToString()
                                            }).ToList();
            ViewBag.odaListe = odalist;
            return View(list);
        }
        public IActionResult EskiRezervasyon()
        {
            var list = c.Rezervasyons.Include(x => x.Musteri).Include(x => x.OdaTip).Include(x => x.Pansiyonlars).Where(x => x.Act == 3).ToList();
            return View(list);
        }
        public IActionResult RezervasyonGetir(int id)
        {
            RezervasyonDetayViewModel detay = new RezervasyonDetayViewModel();
            var rez = c.Rezervasyons.Include(x => x.Musteri).Include(x => x.Pansiyonlars).Include(x => x.OdaTip).SingleOrDefault(x => x.Idno == id);
            detay.OdaAdi = "";
            detay.OdaNo = "";
            if (rez.OdaId != 0)
            {
                var oda = c.Odalars.FirstOrDefault(x => x.Idno == rez.OdaId);
                detay.OdaAdi = oda.OdaAdi;
                detay.OdaNo = oda.OdaNo.ToString();

            }
            detay.GirisTarihi = rez.GirisTarihi;
            detay.CikisTarihi = rez.CikisTarihi;
            detay.Pansiyon = rez.Pansiyonlars.Baslik;
            detay.OdaTipi = rez.OdaTip.Baslik;
            detay.Ucret = rez.Ucret.ToString("N2");
            detay.EkUcret = rez.EkUcret.ToString("N2");
            detay.Aciklama = rez.Aciklama;

            detay.MusteriViewModel = new MusteriViewModel();
            detay.MusteriViewModel.AdiSoyadi = rez.Musteri.Adisoyadi;
            detay.MusteriViewModel.TCNo = rez.Musteri.TcNo;
            detay.MusteriViewModel.DogumTarihi = rez.Musteri.DogumTarihi;
            detay.MusteriViewModel.Telefon = rez.Musteri.Telefon;
            detay.MusteriViewModel.Uyruk = rez.Musteri.Uyruk;
            return View(detay);
        }

        public IActionResult RezervasyonOnay(int id)
        {
            Odalar odalar = new Odalar();

            List<SelectListItem> odalars = (from p in c.Odalars.ToList().Where(p => p.Act == 1).OrderBy(p => p.OdaNo)
                                            select new SelectListItem
                                            {
                                                Text = p.OdaNo + " - " + p.OdaAdi,
                                                Value = p.Idno.ToString()
                                            }).ToList();
            ViewBag.odaAdi = odalars;
            if (id != 0)
            {
                odalar = c.Odalars.SingleOrDefault(x => x.Idno == id);
            }
            //    return RedirectToAction("RezervasyonOnay", "Rezervasyon");
            return View(odalar);
        }

        [HttpPost]
        public IActionResult RezervasyonOnay(int id, int OdaId)
        {
            var dolumu = c.Rezervasyons.FirstOrDefault(x => x.Act == 2 && x.OdaId == OdaId);
            if (dolumu == null)
            {
                var rez = c.Rezervasyons.SingleOrDefault(x => x.Idno == id);
                rez.OdaId = OdaId;
                rez.Act = 2;
                c.Set<Rezervasyon>().Update(rez);
                c.SaveChanges();
                TempData["success"] = "Rezervasyon işlemi tamamlandı";
            }

            else
            {
                TempData["error"] = "Oda dolu! Lütfen başka bir oda seçiniz.";
            }


            return RedirectToAction("Index", "Rezervasyon");
        }
        [HttpGet]
        public IActionResult RezervasyonCikis(int id)
        {
            var rez = c.Rezervasyons.FirstOrDefault(x => x.Idno == id);
            return View(rez);
        }
        [HttpPost]
        public IActionResult RezervasyonCikis(int id, int OdaId, DateTime cikistarih, double ekucret, string aciklama)
        {
            var rez = c.Rezervasyons.FirstOrDefault(x => x.Idno == id && x.OdaId == OdaId);
            //rez.OdaId = OdaId;
            rez.Act = 3;
            rez.CikisTarihi = cikistarih;
            rez.EkUcret = ekucret;
            rez.Aciklama = aciklama;
            c.Set<Rezervasyon>().Update(rez);
            c.SaveChanges();
            TempData["success"] = "Odadan başarıyla çıkış yapıldı.";
            return RedirectToAction("Index", "Rezervasyon");
            
        }
        public IActionResult RezervasyonSil(int id)
        {
            var rez = c.Rezervasyons.SingleOrDefault(x => x.Idno == id);
            if (rez != null)
            {
                rez.Act = 0;
                c.Set<Rezervasyon>().Update(rez);
                c.SaveChanges();
                TempData["success"] = "Rezervasyon başarıyla silindi.";
            }
            else
                TempData["error"] = "Rezervasyon Bulunamadı!";

            return RedirectToAction("Index", "Rezervasyon");
        }
        public IActionResult OdaDurum(int id)
        {
            string json = "";
            List<OdaDurumViewModel> odaList = new List<OdaDurumViewModel>();
            var odalar = c.Odalars.Where(x => x.Act != 0).ToList();
            var rezervasyonlar = c.Rezervasyons.Where(x => x.Act == 2).ToList();
            foreach (var item in odalar)
            {
                OdaDurumViewModel oda = new OdaDurumViewModel();
                oda.OdaAdi = item.OdaAdi;
                oda.OdaNo = item.OdaNo.ToString();
                oda.Durum = "Boş";
                var durum = rezervasyonlar.FirstOrDefault(x => x.OdaId == item.Idno);
                if (durum != null)
                    oda.Durum = "Dolu";
                odaList.Add(oda);
            }
            json = JsonConvert.SerializeObject(odaList);
            return Json(json);
        }
    }
}
