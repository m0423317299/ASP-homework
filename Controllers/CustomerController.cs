using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_homework.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Update(int fid)
        {
            dbhwDataContext db = new dbhwDataContext();
            bloodpressure cust = db.bloodpressure.FirstOrDefault(m => m.f_ID == fid);
            if (cust != null)
            {
                return View(cust);
            }
            return RedirectToAction("List");

        }

        [HttpPost]
        public ActionResult Update(bloodpressure p)
        {
            dbhwDataContext db = new dbhwDataContext();
            bloodpressure cust = db.bloodpressure.FirstOrDefault(m => m.f_ID == p.f_ID);
            if (cust != null)
            {
                cust.f_SBP = p.f_SBP;
                cust.f_DBP = p.f_DBP;
                cust.f_Age = p.f_Age;
                cust.f_time = p.f_time;
                db.SubmitChanges();
            }
            return RedirectToAction("List");
        }


        public ActionResult List()
        {
            dbhwDataContext db = new dbhwDataContext();
            var table = from c in db.bloodpressure
                        select c;
            return View(table);
        }
        public ActionResult Delete(int fid)
        {
            dbhwDataContext db = new dbhwDataContext();
            bloodpressure cust = db.bloodpressure.FirstOrDefault(m => m.f_ID == fid);
            if (cust != null)
            {
                db.bloodpressure.DeleteOnSubmit(cust);
                db.SubmitChanges();
            }
            return RedirectToAction ("List");
        }
        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        public ActionResult New(bloodpressure p)
        {
            dbhwDataContext db = new dbhwDataContext();
            db.bloodpressure.InsertOnSubmit(p);
            db.SubmitChanges();

            return RedirectToAction("List");
        }
        
        
    
    }
}