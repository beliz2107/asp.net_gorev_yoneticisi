using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _asp.net_gorev_yonetici.Models
{
    public class GorevModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }
    }
}