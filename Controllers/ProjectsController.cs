using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using theprojector_vs.Models;

namespace theprojector_vs.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            //var projects = from p in _context.Project select p ;

            //projects = projects.Where(all);

            //foreach(var proj in projects)
            //{
            //    ViewData["projects"] += proj.name;
            //}

            return View();
            //return View(projects);
            //return View(await ProjectsController.ToListAsync());
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
