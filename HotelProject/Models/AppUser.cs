using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Models
{
    public class AppUser:IdentityUser<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
