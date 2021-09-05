using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _asp.net_gorev_yonetici.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public int GorevSayisi { get; set; }
    }
}