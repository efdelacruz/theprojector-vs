using System;

namespace theprojector_vs.Models
{
    public class ProjectAssignment
    {
        public int ID { get; set; }
        public int ProjectId { get; set; }
        public int PersonId { get; set; }

        public Project Project { get; set; }

        public Person Person { get; set; }
        
    }
}