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
    }
}