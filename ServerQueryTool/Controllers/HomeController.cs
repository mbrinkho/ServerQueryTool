using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ServerQueryTool.Models;

namespace ServerQueryTool.Controllers
{
    public class HomeController : Controller
    {
        private CMD db = new CMD();

        // GET: Servers
        public ActionResult ViewAll()
        {
            return View(db.Servers.ToList());
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String Name)
        {
            if (Name == String.Empty)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View("viewall",
                db.Servers.Where(x => x.Name.Contains(Name)).ToList()
                );
        }

        // GET: Servers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Server server = db.Servers.Find(id);
            if (server == null)
            {
                return HttpNotFound();
            }
            return View(server);
        }

        // GET: Servers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,GUID,Deleted,Name,Description,Owner,CreatedDateUTC,RequestedUser,CreatedUser,DNSHostName,OperatingSystem,CanonicalName,DistinguishedName,ADModifiedDateUTC,ADEnabled,IPv4Address,LastLogonDateUTC,VMHost,SerialNumber,CPUSockets,CPUCores,FolderID,ResourcePool,VMVersion,VMID,BuildTemplate,DeletedUser,DeletedDateUTC,Notes")] Server server)
        {
            if (ModelState.IsValid)
            {
                db.Servers.Add(server);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(server);
        }

        // GET: Servers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Server server = db.Servers.Find(id);
            if (server == null)
            {
                return HttpNotFound();
            }
            return View(server);
        }

        // POST: Servers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,GUID,Deleted,Name,Description,Owner,CreatedDateUTC,RequestedUser,CreatedUser,DNSHostName,OperatingSystem,CanonicalName,DistinguishedName,ADModifiedDateUTC,ADEnabled,IPv4Address,LastLogonDateUTC,VMHost,SerialNumber,CPUSockets,CPUCores,FolderID,ResourcePool,VMVersion,VMID,BuildTemplate,DeletedUser,DeletedDateUTC,Notes")] Server server)
        {
            if (ModelState.IsValid)
            {
                db.Entry(server).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(server);
        }

        // GET: Servers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Server server = db.Servers.Find(id);
            if (server == null)
            {
                return HttpNotFound();
            }
            return View(server);
        }

        // POST: Servers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Server server = db.Servers.Find(id);
            db.Servers.Remove(server);
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
