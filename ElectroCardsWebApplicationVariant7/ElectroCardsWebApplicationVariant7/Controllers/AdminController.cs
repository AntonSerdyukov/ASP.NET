using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectroCardsWebApplicationVariant7.Models;

namespace ElectroCardsWebApplicationVariant7.Controllers
{
    public class AdminController : Controller
    {
        ApplicationCardsDbEntities2 db = new ApplicationCardsDbEntities2();

        [HttpGet]
        public ActionResult AddUser(int? id)
        {
            ViewBag.PatientId = id ?? 0;
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {

            db.Users.Attach(user);

            // добавляем информацию о запии в базу данных
            db.Users.Add(user);
            db.SaveChanges();


            // сохраняем в бд все изменения


            return View();
        }

        

        [HttpPost]
        public ActionResult RemoveUser(User user)
        {
            db.Users.Attach(user);
            db.Users.Remove(user);

            db.SaveChanges();


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddPatient(int? id)
        {
            ViewBag.PatientId = id ?? 0;
            return View();
        }

        [HttpPost]
        public ActionResult AddPatient(PatientData patient)
        {

            db.PatientDatas.Attach(patient);

            // добавляем информацию о запии в базу данных
            db.PatientDatas.Add(patient);
            db.SaveChanges();


            // сохраняем в бд все изменения


            return View();
        }

        [HttpGet]
        public ActionResult AddDoctor()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddDoctor(Doctor doctor)
        {

            db.Doctors.Attach(doctor);

            // добавляем информацию о запии в базу данных
            db.Doctors.Add(doctor);
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
        public ActionResult RemovePatient(PatientData patient)
        {
            db.PatientDatas.Attach(patient);
            foreach (PatientData p in db.PatientDatas)
            {
                if (p.Name == patient.Name && p.Surname == patient.Surname)
                {
                    db.PatientDatas.Remove(p);


                }
            }

            db.SaveChanges();


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult RemoveDoctor()
        {

            return View();

        }

        [HttpPost]
        public ContentResult RemoveDoctor(Doctor doctor)
        {
            string content = "";
            db.Doctors.Attach(doctor);
            foreach (Doctor d in db.Doctors)
            {
                content += "9";
                if (d.Name == doctor.Name && d.Surname == doctor.Surname && d.Patronymic == doctor.Patronymic)
                {
                    db.Doctors.Remove(d);
                    content += "5";

                }
            }

            db.SaveChanges();


            return Content(content);
        }



        [HttpGet]
        public ActionResult EditPatientOldData()
        {

            return View();

        }

        

        [HttpGet]
        public ActionResult SearchForOldData()
        {

            return View();

        }


        public ActionResult Index()
        {

            return View();
        }
    }
}