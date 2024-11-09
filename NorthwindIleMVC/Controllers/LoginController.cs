using NorthwindIleMVC.Models;
using NorthwindIleMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindIleMVC.Controllers
{
    public class LoginController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employees employee = db.Employees.FirstOrDefault(e => e.UserName == model.UserName && e.Password == model.Password);
                if (employee != null)
                {
                    Session["employee"] = employee;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.error = "Kullanıcı bulunamadı";
                }
            }
            return View();
        }
    }
}