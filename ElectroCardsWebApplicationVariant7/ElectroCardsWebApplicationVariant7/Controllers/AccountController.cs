using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectroCardsWebApplicationVariant7.Models;

namespace ElectroCardsWebApplicationVariant7.Controllers
{
    public class AccountController : Controller
    {
        ApplicationCardsDbEntities2 db = new ApplicationCardsDbEntities2();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Beginning()
        {

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            ApplicationCardsDbEntities2 db = new ApplicationCardsDbEntities2();
     
            db.Users.Attach(user);
            db.Users.Add(user);
            
            db.SaveChanges();
            switch (user.Role)
            {
                case "user":
                    return RedirectToAction("Index", "Home");
                case "doctor":
                    return RedirectToAction("Index", "Doctor");
                case "editor":
                    return RedirectToAction("Index", "Home");
                case "admin":
                    return RedirectToAction("Index", "Admin");

            }
            return RedirectToAction("Index", "Home");
        

        }
    }
}