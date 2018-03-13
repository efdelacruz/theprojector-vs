using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using theprojector_vs.Models;

namespace theprojector_vs.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Create()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Delete()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
}
