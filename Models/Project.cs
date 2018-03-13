using System;
using System.Collections.Generic;

namespace theprojector_vs.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public decimal Budget { get; set; }
        
        public ICollection<ProjectAssignment> ProjectAssignments { get; set; }
    }
}