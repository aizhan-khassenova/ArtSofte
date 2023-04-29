using ArtSofteEmployees.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtSofteEmployees.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var empBuilder = modelBuilder.Entity<Employee>().ToTable("Employee");

            empBuilder.HasOne(x => x.Department)
                  .WithMany(x => x.Employees)
                  .HasForeignKey(x => x.DepartmentId)
                  .OnDelete(DeleteBehavior.Restrict)
                 ;
            empBuilder.HasOne(x => x.ProgrammingLanguage)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.ProgrammingLanguageId)
                .OnDelete(DeleteBehavior.Restrict)
               ;

            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<ProgrammingLanguage>().ToTable("ProgrammingLanguage");
        }
    }
}
