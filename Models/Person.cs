using System;
using System.Collections.Generic;

namespace theprojector_vs.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public ICollection<ProjectAssignment> ProjectAssignments { get; set; }

    }
}