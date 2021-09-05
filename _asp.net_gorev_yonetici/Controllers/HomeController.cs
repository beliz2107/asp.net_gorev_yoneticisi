using _asp.net_gorev_yonetici.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _asp.net_gorev_yonetici.Controllers
{
    public class HomeController : Controller
    {
        private GorevContext context = new GorevContext();
        // GET: Home
        public ActionResult Index()
        {
            var gorevler = context.Görevler
                .Select(i => new GorevModel()
                {
                    Id = i.Id,
                    Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                    Aciklama = i.Aciklama,
                    EklenmeTarihi = i.EklenmeTarihi,
                    Anasayfa = i.Anasayfa,
                    Onay = i.Onay,
                    
                })
                .Where(i => i.Onay == true && i.Anasayfa == true);
            return View(gorevler.ToList());
        }
    }
}