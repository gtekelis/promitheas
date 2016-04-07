using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PromitheasDomain.Classes;
using PromitheasDomain.DataModel;

namespace PromitheasDashboardMVC.Controllers
{
    public class SocialMediasController : Controller
    {
        private PromitheasContext db = new PromitheasContext();

        //my repository
        private readonly DisconnectedRepository _repo = new DisconnectedRepository();

        // GET: SocialMedias
        public ActionResult Index()
        {
            return View(db.ShopSocialMedia.ToList());
        }

        // GET: SocialMedias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialMedia socialMedia = db.ShopSocialMedia.Find(id);
            if (socialMedia == null)
            {
                return HttpNotFound();
            }
            return View(socialMedia);
        }

        // GET: SocialMedias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialMedias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SocialMediaId,ShopId,SocialMediaUrl,IsActive")] SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                _repo.SaveNewShopSocialMedia(socialMedia);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(socialMedia);
        }

        // GET: SocialMedias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialMedia socialMedia = db.ShopSocialMedia.Find(id);
            if (socialMedia == null)
            {
                return HttpNotFound();
            }
            return View(socialMedia);
        }

        // POST: SocialMedias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SocialMediaId,ShopId,SocialMediaUrl,IsActive")] SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socialMedia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socialMedia);
        }

        // GET: SocialMedias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialMedia socialMedia = db.ShopSocialMedia.Find(id);
            if (socialMedia == null)
            {
                return HttpNotFound();
            }
            return View(socialMedia);
        }

        // POST: SocialMedias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SocialMedia socialMedia = db.ShopSocialMedia.Find(id);
            db.ShopSocialMedia.Remove(socialMedia);
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
