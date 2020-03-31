using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using ElectroCardsWebApplicationVariant7.Models;


namespace ElectroCardsWebApplicationVariant7.Controllers
{
    public class HomeController : Controller
    {
        ApplicationCardsDbEntities1 db = new ApplicationCardsDbEntities1();
    

        [HttpGet]
        public ActionResult AddPatient(int? id)
        {
            ViewBag.PatientId = id ?? 0;
            return View();
        }

        [HttpPost]
        public ActionResult AddPatient(Patient patient)
        {
           
            db.Patients.Attach(patient);
            
            // добавляем информацию о запии в базу данных
            db.Patients.Add(patient);
            db.SaveChanges();


            // сохраняем в бд все изменения


            return View();
        }

        [HttpGet]
        public ActionResult RemovePatient()
        {
            
            return View();

        }

        [HttpPost]
        public ActionResult RemovePatient(Patient patient)
        {
            db.Patients.Attach(patient);
            foreach (Patient p in db.Patients)
            {
                if (p.Name == patient.Name && p.Surname == patient.Surname)
                {
                    db.Patients.Remove(p);
                    

                }
            }

            db.SaveChanges();


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditPatientOldData()
        {

            return View();

        }

        [HttpPost]
        public ActionResult EditPatientOldData(Patient oldPatient,Patient newPatient)
        {
            db.Patients.Attach(oldPatient);
            db.Patients.Remove(oldPatient);
            
            db.Patients.Add(newPatient);
            db.Entry(newPatient).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
      
            return View();
        }
    }
}