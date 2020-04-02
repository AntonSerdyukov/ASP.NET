using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectroCardsWebApplicationVariant7.Models;

namespace ElectroCardsWebApplicationVariant7.Controllers
{
    public class UserController : Controller
    {
       
        ApplicationCardsDbEntities2 db = new ApplicationCardsDbEntities2();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayPatients()
        {
            var patients = db.PatientDatas;
            return View(patients.ToList());
        }

        [HttpGet]
        public ActionResult AddPatient(int id)
        {

            PatientData patient = db.PatientDatas.Find(id);

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

        

        
        public ActionResult SearchForPatientsByRecordingDate(string searchString)
        {
            var patients = from p in db.PatientDatas
                           select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                patients = patients.Where(p => p.RecordDate.ToString().Contains(searchString));
            }
      
            return View(patients.ToList());
        }

        public ActionResult SearchForPatientsByDiagnose(string searchString)
        {
            var patients = from p in db.PatientDatas
                           select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                patients = patients.Where(p => p.Diagnose.Contains(searchString));
            }

            return View(patients.ToList());
        }

        public ActionResult SearchForPatientsByDoctorPosition(string searchString)
        {
            var patients = from p in db.PatientDatas
                           select p;
            if (!string.IsNullOrEmpty(searchString))
            {
                patients = patients.Where(p => p.Doctor.Position.Contains(searchString));

            }

            return View(patients.ToList());
        }

        



    }
}