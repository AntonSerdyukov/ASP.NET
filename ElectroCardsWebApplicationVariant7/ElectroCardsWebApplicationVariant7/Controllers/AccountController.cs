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
        ApplicationCardsDbEntities db = new ApplicationCardsDbEntities();

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
            ApplicationCardsDbEntities db = new ApplicationCardsDbEntities();
     
            db.Users.Attach(user);
            db.Users.Add(user);
            
            db.SaveChanges();
            return RedirectToAction("Home","Index"); 

        }
    }
}