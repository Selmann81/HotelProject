﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Models
{
    public class Pansiyonlar
    {
        [Key]
        public int Idno { get; set; }
        public string Baslik { get; set; }
        public double Ucret { get; set; }
        public int Act { get; set; }
    }
}
