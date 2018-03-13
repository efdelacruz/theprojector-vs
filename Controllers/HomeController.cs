using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using theprojector_vs.Models;
using Theprojector.Data;
using Npgsql;

namespace theprojector_vs.Controllers
{
    public class HomeController : Controller
    {
        TheprojectorContext dbContext;

        public HomeController(TheprojectorContext dbContext) {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            Console.WriteLine("\n--------WELCOME--------.\n");
            //test pgsql

            var connString = "Host=localhost;Username=postgres;Password=password;Database=theprojector";

            NpgsqlConnection conn = new NpgsqlConnection(connString); 
            conn.Open(); 
            if (conn.State == System.Data.ConnectionState.Open) 
                Console.WriteLine("\n---------Success open postgreSQL connection.\n");
            
            Console.WriteLine("\n--------CLOSE.\n");

            conn.Close(); 

            return View();
        }

        public IActionResult DbContext() 
        {
            bool peopleExist = this.dbContext.Persons.Any();
        

            return this.Json(new { message = "ok" });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
