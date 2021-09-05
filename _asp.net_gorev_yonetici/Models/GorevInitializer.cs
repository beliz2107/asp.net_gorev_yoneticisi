using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _asp.net_gorev_yonetici.Models
{
    public class GorevInitializer:DropCreateDatabaseIfModelChanges<GorevContext>
    {
        protected override void Seed(GorevContext context)
        {
            List<Category> Kategoriler = new List<Category>()
            {
                new Category() {KategoriAdi="C#"},
                new Category() {KategoriAdi="Asp.net MVC"},
                new Category() {KategoriAdi="Asp.net WebForm"},
                new Category() {KategoriAdi="Windows Form"},
            };
            foreach (var item in Kategoriler)
            {
                context.Kategoriler.Add(item);
            }
                context.SaveChanges();
            List<Gorev> Görevler = new List<Gorev>()
            {
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10),  Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=1},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-30),  Anasayfa=false, Onay=true, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=1},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10),  Anasayfa=true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=1},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10),  Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=2},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20),  Anasayfa=false, Onay=true, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=2},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10),  Anasayfa=true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=2},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-15),  Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=3},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10),  Anasayfa=true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=3},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20),  Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=3},
                new Gorev() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10),  Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=4},
            };

            foreach  (var item in Görevler)
            {
                context.Görevler.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}