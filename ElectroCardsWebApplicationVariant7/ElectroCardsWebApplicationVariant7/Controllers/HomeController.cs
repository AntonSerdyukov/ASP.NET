using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectroCardsWebApplicationVariant7.Models;


namespace ElectroCardsWebApplicationVariant7.Controllers
{
    public class HomeController : Controller
    {
        ApplicationCardsDbEntities db = new ApplicationCardsDbEntities();

        [HttpGet]
        public ActionResult AddPatient()
        {

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

            foreach (Patient p in db.Patients)
            {
                if (p.Name == patient.Name && p.Surname == patient.Surname)
                {
                    db.Patients.Remove(p);
                   

                }
            }


            return RedirectToAction("Index");


            // удаляем запись из базы данных в базу данных

            // сохраняем в бд все изменения


        }

        public ActionResult Index()
        {
      
            return View();
        }
    }
}