using Microsoft.AspNet.Identity;
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
    public class JobsController : Controller
    {
        private JobSystemContext db = new JobSystemContext();

        // GET: Jobs
        public ViewResult Index()
        {
            return View();
        }

        // GET: Jobs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jobs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Job job)
        {
            if (ModelState.IsValid)
            {
                string currentUserId = User.Identity.GetUserId();
                var userId = User.Identity.GetUserName();
                var currentUser = db.WorklyUsers.Where(u => u.Email == userId).ToList<WorklyUser>();
                job.UserId= User.Identity.GetUserId();
                job.Name = currentUser[0].Name;
                job.Phone = currentUser[0].Phone;
                job.Surname = currentUser[0].Surname;
                db.Jobs.Add(job);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(job);
        }

        public ActionResult Checked(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // GET: Jobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(Job job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(job);
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
