using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _asp.net_gorev_yonetici.Models;

namespace _asp.net_gorev_yonetici.Controllers
{
    public class GorevController : Controller
    {
        private GorevContext db = new GorevContext();

        // GET: Gorev
        public ActionResult Index()
        {
            var görevler = db.Görevler.Include(g => g.Category);
            return View(görevler.ToList());
        }

        // GET: Gorev/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gorev gorev = db.Görevler.Find(id);
            if (gorev == null)
            {
                return HttpNotFound();
            }
            return View(gorev);
        }

        // GET: Gorev/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Kategoriler, "Id", "KategoriAdi");
            return View();
        }

        // POST: Gorev/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Baslik,Aciklama,Resim,Icerik,EklenmeTarihi,Onay,Anasayfa,CategoryId")] Gorev gorev)
        {
            if (ModelState.IsValid)
            {
                db.Görevler.Add(gorev);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Kategoriler, "Id", "KategoriAdi", gorev.CategoryId);
            return View(gorev);
        }

        // GET: Gorev/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gorev gorev = db.Görevler.Find(id);
            if (gorev == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Kategoriler, "Id", "KategoriAdi", gorev.CategoryId);
            return View(gorev);
        }

        // POST: Gorev/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Baslik,Aciklama,Resim,Icerik,EklenmeTarihi,Onay,Anasayfa,CategoryId")] Gorev gorev)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gorev).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Kategoriler, "Id", "KategoriAdi", gorev.CategoryId);
            return View(gorev);
        }

        // GET: Gorev/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gorev gorev = db.Görevler.Find(id);
            if (gorev == null)
            {
                return HttpNotFound();
            }
            return View(gorev);
        }

        // POST: Gorev/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gorev gorev = db.Görevler.Find(id);
            db.Görevler.Remove(gorev);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
