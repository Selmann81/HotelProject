using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Models
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}
