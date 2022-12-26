using HotelProject.Models;
using HotelProject.ViewModels.Site;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MevcutRezervasyonlarController : Controller
    {
        private readonly SiteContext c;
        public MevcutRezervasyonlarController(SiteContext c)
        {
            this.c = c;
        }
        public IActionResult MevcutRezervasyonlar(int id, int OdaId)
        {
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
        }
    }
}
