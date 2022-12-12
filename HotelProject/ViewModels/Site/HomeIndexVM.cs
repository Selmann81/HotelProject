using HotelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.ViewModels.Site
{
    public class HomeIndexVM
    {
        public List<OdaTip> OdaTips { get; set; }
        public List<Pansiyonlar> Pansiyonlars { get; set; }
    }
}
