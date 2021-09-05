using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _asp.net_gorev_yonetici.Models
{
    public class GorevContext:DbContext
    {
        public GorevContext():base("gorevDb")
        {
            Database.SetInitializer(new GorevInitializer());
        }
        public DbSet<Gorev> Görevler { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}