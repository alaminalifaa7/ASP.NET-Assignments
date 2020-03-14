using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevSkill.LibrarySystem.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Assignment_3_AdminFrontend.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class DataController : Controller
    {
        //private readonly IConfiguration _configuration;
        //public DataController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        public IActionResult Index()
        {
           var model = new DataModel();
            return View(model);
        }
        public IActionResult GetBooks()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = new DataModel();
            var data = model.GetBooks(tableModel);
            return Json(data);
        }
    }
}