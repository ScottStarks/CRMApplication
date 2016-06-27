using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRMApplication.Models;

namespace CRMApplication.Controllers
{
    public class NoteViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NoteViewModels
        public ActionResult Index()
        {
            return View(db.NoteViewModels.ToList());
        }

        // GET: NoteViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoteViewModel noteViewModel = db.NoteViewModels.Find(id);
            if (noteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(noteViewModel);
        }

        // GET: NoteViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoteViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NoteID,CustomerID,Body,UserCreated")] NoteViewModel noteViewModel)
        {
            if (ModelState.IsValid)
            {
                db.NoteViewModels.Add(noteViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(noteViewModel);
        }

        // GET: NoteViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoteViewModel noteViewModel = db.NoteViewModels.Find(id);
            if (noteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(noteViewModel);
        }

        // POST: NoteViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NoteID,CustomerID,Body,UserCreated")] NoteViewModel noteViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noteViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noteViewModel);
        }

        // GET: NoteViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoteViewModel noteViewModel = db.NoteViewModels.Find(id);
            if (noteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(noteViewModel);
        }

        // POST: NoteViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NoteViewModel noteViewModel = db.NoteViewModels.Find(id);
            db.NoteViewModels.Remove(noteViewModel);
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
