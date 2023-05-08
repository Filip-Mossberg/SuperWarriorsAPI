using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
         
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeReport> TimeReports { get; set; }

        protected override void OnModelCreating(ModelBuilder md)
        {
            base.OnModelCreating(md);

            // Seed Data
            // Employee
            md.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 1,
                Name = "Damir",
                ProjectID = 1
            });
            md.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 2,
                Name = "Daniel",
                ProjectID = 2
            });
            md.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 3,
                Name = "Filip",
                ProjectID = 3
            });
            md.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 4,
                Name = "Anas",
                ProjectID = 1
            });
            md.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 5,
                Name = "Alvin",
                ProjectID = 3
            });

            // Project
            md.Entity<Project>().HasData(new Project
            {
                ProjectID = 1,
                ProjectName = "Group1"
            });
            md.Entity<Project>().HasData(new Project
            {
                ProjectID = 2,
                ProjectName = "Group2"
            });
            md.Entity<Project>().HasData(new Project
            {
                ProjectID = 3,
                ProjectName = "Group3"
            });

            // TimeReport
            md.Entity<TimeReport>().HasData(new TimeReport
            {
                TimeReportID = 1,
                EmployeeID = 2,
                Week = 15
            });
            md.Entity<TimeReport>().HasData(new TimeReport
            {
                TimeReportID = 2,
                EmployeeID = 2,
                Week = 10
            });
            md.Entity<TimeReport>().HasData(new TimeReport
            {
                TimeReportID = 3,
                EmployeeID = 3,
                Week = 40
            });
            md.Entity<TimeReport>().HasData(new TimeReport
            {
                TimeReportID = 4,
                EmployeeID = 5,
                Week = 18
            });
            md.Entity<TimeReport>().HasData(new TimeReport
            {
                TimeReportID = 5,
                EmployeeID = 4,
                Week = 36
            });
            md.Entity<TimeReport>().HasData(new TimeReport
            {
                TimeReportID = 6,
                EmployeeID = 4,
                Week = 14
            });

        }
    }
}
