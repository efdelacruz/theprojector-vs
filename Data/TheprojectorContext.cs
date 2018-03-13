using theprojector_vs.Models;
using Microsoft.EntityFrameworkCore;

namespace Theprojector.Data
{
    public class TheprojectorContext : DbContext
    {
        public TheprojectorContext(DbContextOptions<TheprojectorContext> options) : base(options)
        {
            
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectAssignment> ProjectAssignments { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<ProjectAssignment>().ToTable("ProjectAssignment");
            modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}