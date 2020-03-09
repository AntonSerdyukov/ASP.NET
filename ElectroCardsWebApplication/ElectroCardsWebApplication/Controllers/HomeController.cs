using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectroCardsWebApplication.Models;

namespace ElectroCardsWebApplication.Controllers
{
    public class HomeController : Controller
    {
        PatientContext db=new PatientContext();

        [HttpGet]
        public ActionResult AddPatient(int? id)
        {
            ViewBag.PatientId = id ?? 0;
            return View();
        }

        [HttpPost]
        public ActionResult AddPatient(Patient patient)
        {
         
            // добавляем информацию о запии в базу данных
            db.Patients.Add(patient);
            // сохраняем в бд все изменения
            db.SaveChanges();
            
            return View();
        }

        public ActionResult Index()
        {
            // получаем из бд все объекты Patient
           // IEnumerable<Patient> patients = db.Patients;
            // передаем все объекты в динамическое свойство Patients в ViewBag
          //  ViewBag.Patient = patients;
            // возвращаем представление
            return View();
        }
    }
}