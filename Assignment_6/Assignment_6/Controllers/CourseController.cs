using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment_6.Models;

namespace Assignment_6.Controllers
{
    public class CourseController : Controller
    {


        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(CourseModel model)
        {
            model.CreateCourse();
            return View();
        }
    }
}