using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.ViewModels.Site
{
    public class Rezervasyonlar
    {
        public int MusteriId { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int TelefonNo { get; set; }
        public int Pansiyonlar { get; set; }
        public int OdaId{ get; set; }
        public int Yetiskin { get; set; }
        public int Cocuk { get; set; }
    }
}
