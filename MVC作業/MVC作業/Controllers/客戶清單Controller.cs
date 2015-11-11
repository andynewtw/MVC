using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC作業.Models;

namespace MVC作業.Controllers
{
    public class 客戶清單Controller : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: 客戶清單
        public ActionResult Index(string search)
        {
            //return View(db.客戶清單.ToList());
            var data = db.客戶清單.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                data = data.Where(p => p.客戶名稱.Contains(search));
            }
            return View(data);
        }

        // GET: 客戶清單/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶清單 客戶清單 = db.客戶清單.Find(id);
            if (客戶清單 == null)
            {
                return HttpNotFound();
            }
            return View(客戶清單);
        }

        // GET: 客戶清單/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 客戶清單/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "客戶編號,客戶名稱,聯絡人數量,銀行帳戶數量")] 客戶清單 客戶清單)
        {
            if (ModelState.IsValid)
            {
                db.客戶清單.Add(客戶清單);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(客戶清單);
        }

        // GET: 客戶清單/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶清單 客戶清單 = db.客戶清單.Find(id);
            if (客戶清單 == null)
            {
                return HttpNotFound();
            }
            return View(客戶清單);
        }

        // POST: 客戶清單/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "客戶編號,客戶名稱,聯絡人數量,銀行帳戶數量")] 客戶清單 客戶清單)
        {
            if (ModelState.IsValid)
            {
                db.Entry(客戶清單).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(客戶清單);
        }

        // GET: 客戶清單/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶清單 客戶清單 = db.客戶清單.Find(id);
            if (客戶清單 == null)
            {
                return HttpNotFound();
            }
            return View(客戶清單);
        }

        // POST: 客戶清單/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            客戶清單 客戶清單 = db.客戶清單.Find(id);
            db.客戶清單.Remove(客戶清單);
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
