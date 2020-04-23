using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_6.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegistrationModel model)
        {
            if (model.isPaymentComplete != true)
            {
                model.isPaymentComplete = false;
                model.CreateRegistration();
            }
            else
            {
                model.isPaymentComplete = true;
                model.CreateRegistration();
            }
            
            return View();
        }
    }
}