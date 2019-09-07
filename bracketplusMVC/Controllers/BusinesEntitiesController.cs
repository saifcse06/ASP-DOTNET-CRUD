using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bracketplusMVC.Models;
using bracketplusMVC.Context;
using bracketplusMVC.Models.ViewModel;

namespace bracketplusMVC.Controllers
{
    public class BusinesEntitiesController : Controller
    {
        private BracketPlusContext db = new BracketPlusContext();

        // GET: /BusinesEntities/
        public ActionResult Index()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();            
            var BusinessList = db.BusinessEntities.ToList();
            watch.Stop();
            System.Diagnostics.Debug.WriteLine("Execution List Total Time: " + watch.ElapsedMilliseconds + "ms");
            return View(BusinessList);
        }

        // GET: /BusinesEntities/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessEntities businessentities = db.BusinessEntities.Find(id);
            if (businessentities == null)
            {
                return HttpNotFound();
            }
            return View(businessentities);
        }

        // GET: /BusinesEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /BusinesEntities/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BusinessEntitiesVM objBusiness)
        {
            if (ModelState.IsValid)
            { 
                var watch = System.Diagnostics.Stopwatch.StartNew();
                BusinessEntities objBusinessEntities = new BusinessEntities();

                //BusinessEntities objUb = db.BusinessEntities.Where(x => x.BusinessId == objBusiness.BusinessId).FirstOrDefault;

                objBusinessEntities.Code = objBusiness.Code;
                objBusinessEntities.Email = objBusiness.Email;
                objBusinessEntities.Name = objBusiness.Name;
                objBusinessEntities.Street = objBusiness.Street;
                objBusinessEntities.City = objBusiness.City;
                objBusinessEntities.State = objBusiness.State;
                objBusinessEntities.Zip = objBusiness.Zip;
                objBusinessEntities.Country = objBusiness.Country;
                objBusinessEntities.Mobile = objBusiness.Mobile;
                objBusinessEntities.Phone = objBusiness.Phone;
                objBusinessEntities.ContactPerson = objBusiness.ContactPerson;
                objBusinessEntities.ReferredBy = objBusiness.ReferredBy;
                objBusinessEntities.Logo = objBusiness.Logo;
                objBusinessEntities.Status = objBusiness.Status;
                objBusinessEntities.Balance = objBusiness.Balance;
                objBusinessEntities.LoginUrl = objBusiness.LoginUrl;
                objBusinessEntities.SecurityCode = objBusiness.SecurityCode;
                objBusinessEntities.SMTPServer = objBusiness.SMTPServer;
                objBusinessEntities.SMTPPort = objBusiness.SMTPPort;
                objBusinessEntities.SMTPUsername = objBusiness.SMTPUsername;
                objBusinessEntities.SMTPPassword = objBusiness.SMTPPassword;
                objBusinessEntities.Deleted = objBusiness.Deleted;
                objBusinessEntities.CreatedOnUtc = DateTime.Now;
                objBusinessEntities.UpdatedOnUtc = DateTime.Now.ToString();
                objBusinessEntities.CurrentBalance = objBusiness.CurrentBalance;

                db.BusinessEntities.Add(objBusinessEntities);
                db.SaveChanges();                 
                watch.Stop();
                System.Diagnostics.Debug.WriteLine("Execution Create Total Time: " + watch.ElapsedMilliseconds + "ms");
            //Console.WriteLine("Execution Create Time: {watch.ElapsedMilliseconds} ms");
                return RedirectToAction("Index");
            }

            return View(objBusiness);
        }

        // GET: /BusinesEntities/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessEntitiesVM objBussiness = new BusinessEntitiesVM();

            BusinessEntities obj = db.BusinessEntities.Find(id);
            objBussiness.BusinessId = obj.BusinessId;
            objBussiness.Code = obj.Code;
            objBussiness.Email = obj.Email;
            objBussiness.Name = obj.Name;
            objBussiness.Street = obj.Street;
            objBussiness.City = obj.City;
            objBussiness.State = obj.State;
            objBussiness.Zip = obj.Zip;
            objBussiness.Country = obj.Country;
            objBussiness.Mobile = obj.Mobile;
            objBussiness.Phone = obj.Phone;
            objBussiness.ContactPerson = obj.ContactPerson;
            objBussiness.ReferredBy = obj.ReferredBy;
            objBussiness.Logo = obj.Logo;
            objBussiness.Status = obj.Status;
            objBussiness.Balance = obj.Balance;
            objBussiness.LoginUrl = obj.LoginUrl;
            objBussiness.SecurityCode = obj.SecurityCode;
            objBussiness.SMTPServer = obj.SMTPServer;
            objBussiness.SMTPPort = obj.SMTPPort;
            objBussiness.SMTPUsername = obj.SMTPUsername;
            objBussiness.SMTPPassword = obj.SMTPPassword;
            objBussiness.Deleted = obj.Deleted;
            objBussiness.CreatedOnUtc = DateTime.Now;
            objBussiness.UpdatedOnUtc = DateTime.Now.ToString();
            objBussiness.CurrentBalance = obj.CurrentBalance;
            if (obj == null)
            {
                return HttpNotFound();
            }
            return View(objBussiness);
        }

        // POST: /BusinesEntities/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BusinessEntitiesVM objBusiness)
        {
            if (ModelState.IsValid)
            {

                var watch = System.Diagnostics.Stopwatch.StartNew();
                BusinessEntities objBusinessEntities = db.BusinessEntities.Where(x => x.BusinessId == objBusiness.BusinessId).FirstOrDefault();

                objBusinessEntities.Code = objBusiness.Code;
                objBusinessEntities.Email = objBusiness.Email;
                objBusinessEntities.Name = objBusiness.Name;
                objBusinessEntities.Street = objBusiness.Street;
                objBusinessEntities.City = objBusiness.City;
                objBusinessEntities.State = objBusiness.State;
                objBusinessEntities.Zip = objBusiness.Zip;
                objBusinessEntities.Country = objBusiness.Country;
                objBusinessEntities.Mobile = objBusiness.Mobile;
                objBusinessEntities.Phone = objBusiness.Phone;
                objBusinessEntities.ContactPerson = objBusiness.ContactPerson;
                objBusinessEntities.ReferredBy = objBusiness.ReferredBy;
                objBusinessEntities.Logo = objBusiness.Logo;
                objBusinessEntities.Status = objBusiness.Status;
                objBusinessEntities.Balance = objBusiness.Balance;
                objBusinessEntities.LoginUrl = objBusiness.LoginUrl;
                objBusinessEntities.SecurityCode = objBusiness.SecurityCode;
                objBusinessEntities.SMTPServer = objBusiness.SMTPServer;
                objBusinessEntities.SMTPPort = objBusiness.SMTPPort;
                objBusinessEntities.SMTPUsername = objBusiness.SMTPUsername;
                objBusinessEntities.SMTPPassword = objBusiness.SMTPPassword;
                objBusinessEntities.Deleted = objBusiness.Deleted;
                objBusinessEntities.CreatedOnUtc = DateTime.Now;
                objBusinessEntities.UpdatedOnUtc = DateTime.Now.ToString();
                objBusinessEntities.CurrentBalance = objBusiness.CurrentBalance;

            
                db.SaveChanges();
                watch.Stop();
                System.Diagnostics.Debug.WriteLine("Execution Edit-update Total Time: " + watch.ElapsedMilliseconds + "ms");
                return RedirectToAction("Index");
            }
            return View(objBusiness);
        }

        // GET: /BusinesEntities/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            BusinessEntities businessentities = db.BusinessEntities.Find(id);
            watch.Stop();
            System.Diagnostics.Debug.WriteLine("Execution Delete Total Time: " + watch.ElapsedMilliseconds + "ms");
            if (businessentities == null)
            {
                return HttpNotFound();
            }
            return View(businessentities);
        }

        // POST: /BusinesEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            BusinessEntities businessentities = db.BusinessEntities.Find(id);
            db.BusinessEntities.Remove(businessentities);
            db.SaveChanges();
            watch.Stop();
            System.Diagnostics.Debug.WriteLine("Execution DeleteConfirmed Total Time: " + watch.ElapsedMilliseconds + "ms");
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
