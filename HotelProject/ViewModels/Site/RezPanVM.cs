using HotelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.ViewModels.Site
{
    public class RezPanVM
    {
        public List<Pansiyonlar> Pansiyonlars { get; set; }

        public List<Rezervasyon> Rezervasyonlars{ get; set; }
    }
}
