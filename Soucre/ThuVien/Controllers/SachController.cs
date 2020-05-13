using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThuVien.Models;

namespace ThuVien.Controllers
{
    public class SachController : Controller
    {
        private Model1 db = new Model1();

        // GET: Saches
        public ActionResult Index()
        {
            var saches = db.Saches.Include(s => s.LoaiSach1).Include(s => s.NXB1).Include(s => s.PhieuMuon).Include(s => s.TacGia1).Include(s => s.ViTri1);
            return View(saches.ToList());
        }

        // GET: Saches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Saches.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

        // GET: Saches/Create
        public ActionResult Create()
        {
            ViewBag.LoaiSach = new SelectList(db.LoaiSaches, "ID", "MaLoaiSach");
            ViewBag.NXB = new SelectList(db.NXBs, "ID", "MaNXB");
            ViewBag.Muon = new SelectList(db.PhieuMuons, "ID", "MaMuon");
            ViewBag.TacGia = new SelectList(db.TacGias, "ID", "MaTacGia");
            ViewBag.ViTri = new SelectList(db.ViTris, "ID", "MaViTri");
            return View();
        }

        // POST: Saches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MaSach,TenSach,LoaiSach,NamXB,NXB,TacGia,ViTri,SoLuong,Muon,NgonNgu,TimeCreate,TimeUpdate")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                db.Saches.Add(sach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LoaiSach = new SelectList(db.LoaiSaches, "ID", "MaLoaiSach", sach.LoaiSach);
            ViewBag.NXB = new SelectList(db.NXBs, "ID", "MaNXB", sach.NXB);
            ViewBag.Muon = new SelectList(db.PhieuMuons, "ID", "MaMuon", sach.Muon);
            ViewBag.TacGia = new SelectList(db.TacGias, "ID", "MaTacGia", sach.TacGia);
            ViewBag.ViTri = new SelectList(db.ViTris, "ID", "MaViTri", sach.ViTri);
            return View(sach);
        }

        // GET: Saches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Saches.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoaiSach = new SelectList(db.LoaiSaches, "ID", "MaLoaiSach", sach.LoaiSach);
            ViewBag.NXB = new SelectList(db.NXBs, "ID", "MaNXB", sach.NXB);
            ViewBag.Muon = new SelectList(db.PhieuMuons, "ID", "MaMuon", sach.Muon);
            ViewBag.TacGia = new SelectList(db.TacGias, "ID", "MaTacGia", sach.TacGia);
            ViewBag.ViTri = new SelectList(db.ViTris, "ID", "MaViTri", sach.ViTri);
            return View(sach);
        }

        // POST: Saches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaSach,TenSach,LoaiSach,NamXB,NXB,TacGia,ViTri,SoLuong,Muon,NgonNgu,TimeCreate,TimeUpdate")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiSach = new SelectList(db.LoaiSaches, "ID", "MaLoaiSach", sach.LoaiSach);
            ViewBag.NXB = new SelectList(db.NXBs, "ID", "MaNXB", sach.NXB);
            ViewBag.Muon = new SelectList(db.PhieuMuons, "ID", "MaMuon", sach.Muon);
            ViewBag.TacGia = new SelectList(db.TacGias, "ID", "MaTacGia", sach.TacGia);
            ViewBag.ViTri = new SelectList(db.ViTris, "ID", "MaViTri", sach.ViTri);
            return View(sach);
        }

        // GET: Saches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Saches.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

        // POST: Saches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sach sach = db.Saches.Find(id);
            db.Saches.Remove(sach);
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
