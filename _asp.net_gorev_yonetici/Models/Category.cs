using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _asp.net_gorev_yonetici.Models
{
    public class Category
    {
    
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<Gorev> Görevler { get; set; }
    }
}