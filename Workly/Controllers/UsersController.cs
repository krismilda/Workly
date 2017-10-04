using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Workly.Models;

namespace Workly.Controllers
{
    public class UsersController : Controller
    {
        private JobSystemContext db = new JobSystemContext();

        // GET: Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorklyUser worklyUser = db.Users.Find(id);
            if (worklyUser == null)
            {
                return HttpNotFound();
            }
            return View(worklyUser);
        }

        // GET: Users/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorklyUserId,Email,Rating")] WorklyUser worklyUser)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(worklyUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(worklyUser);
        }*/

        // GET: Users/Edit/5
        /*public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorklyUser worklyUser = db.Users.Find(id);
            if (worklyUser == null)
            {
                return HttpNotFound();
            }
            return View(worklyUser);
        }*/

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorklyUserId,Email,Rating")] WorklyUser worklyUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(worklyUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(worklyUser);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorklyUser worklyUser = db.Users.Find(id);
            if (worklyUser == null)
            {
                return HttpNotFound();
            }
            return View(worklyUser);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorklyUser worklyUser = db.Users.Find(id);
            db.Users.Remove(worklyUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }*/

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
