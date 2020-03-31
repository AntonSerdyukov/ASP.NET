using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectroCardsWebApplicationVariant7.Models;

namespace ElectroCardsWebApplicationVariant7.Controllers
{
    public class DoctorController : Controller
    {
        ApplicationCardsDbEntities2 db = new ApplicationCardsDbEntities2();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchForPatients()
        {
            var patients = db.PatientDatas;
            return View(patients.ToList());
        }

        [HttpGet]
        public ActionResult AddPatient(int id)
        {
            
            PatientData patient=db.PatientDatas.Find(id);
            
            db.PatientDatas.Remove(patient);
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult AddPatient(PatientData patient)
        {
            db.PatientDatas.Add(patient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditDoctor()
        {
            var doctors = db.Doctors;
            return View(doctors.ToList());
        }

        [HttpGet]
        public ActionResult AddDoctor(int id)
        {

            Doctor doctor = db.Doctors.Find(id);

            db.Doctors.Remove(doctor);
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult AddDoctor(Doctor doctor)
        {
            db.Doctors.Add(doctor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}