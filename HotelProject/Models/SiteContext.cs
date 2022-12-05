using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Models
{
    public class SiteContext: DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Odalar> Odalars { get; set; }
        public DbSet<OdaTip> OdaTips { get; set; }
        public DbSet<Pansiyonlar> Pansiyonlars { get; set; }
        public DbSet<OdaOzellik> OdaOzelliks  { get; set; }

    }
}
