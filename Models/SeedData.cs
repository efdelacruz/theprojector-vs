using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Theprojector.Data;

namespace theprojector_vs.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TheprojectorContext(null))
            {
                Console.WriteLine("\n----Inside service provider");
                // Check if existing
                if (context.Persons.Any())
                {
                    return;   // DB has been seeded
                }

                context.Persons.AddRange(
                     new Person
                     {
                         FirstName = "Admin",
                         LastName = "Account",
                         UserName = "admin",
                         Password = "admin",
                         Role = "admin"
                     }
                );

                context.Projects.AddRange(
                     new Project
                     {
                         Code = "DEF001",
                         Name = "Default",
                         Remarks = "Default Project included",
                         Budget = 50000.00m
                     }
                );

                context.ProjectAssignments.AddRange(
                     new ProjectAssignment
                     {
                         ProjectId = 1,
                         PersonId = 1
                     }
                );

                context.SaveChanges();
            }
        }
    }
}