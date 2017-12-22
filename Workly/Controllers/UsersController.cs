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
            return View(db.WorklyUsers.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorklyUser worklyUser = db.WorklyUsers.Find(id);
            if (worklyUser == null)
            {
                return HttpNotFound();
            }
            worklyUser.ReviewList = db.Review.Where(u => u.Email==worklyUser.Email).ToList<Review>();
            return View(worklyUser);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorklyUser worklyUser = db.WorklyUsers.Find(id);
            if (worklyUser == null)
            {
                return HttpNotFound();
            }
            return View(worklyUser);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorklyUserId,Email,Rating, Review")] WorklyUser worklyUser)
        {
            var review = new Review();
            review.ReviewId = worklyUser.WorklyUserId;
            review.Email = worklyUser.Email;
            review.Comment = worklyUser.Review.Comment;
            db.Review.Add(review);
            var user = db.WorklyUsers.Find(worklyUser.WorklyUserId);
            int a = worklyUser.Rating.Rate;
            user.Rating.Sum += worklyUser.Rating.Rate;
            user.Rating.Times++;
            user.Rating.Average =user.Rating.Sum / user.Rating.Times;

            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(worklyUser);
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
