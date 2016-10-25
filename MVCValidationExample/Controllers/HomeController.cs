using MVCValidationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCValidationExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(Register reg)
        {
            ViewBag.Message = "Your application description page.";

            return View(reg);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
        //
        // GET: /Home/

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Register registerDetails)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Success = "User Successfully Registered !!";
                return RedirectToAction("about", registerDetails);
            }
            else
            {
                return View("Signup", registerDetails);
            }
        }
    }
}


