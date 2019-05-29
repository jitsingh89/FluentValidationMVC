using FluentValidationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentValidationMVC.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddUser()
        {
            UserViewModel model = new UserViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Implement your application logic  
            }
            return View(model);
        }
    }
}