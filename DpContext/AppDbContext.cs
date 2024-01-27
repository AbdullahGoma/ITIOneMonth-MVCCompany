using Microsoft.EntityFrameworkCore;
using ProjectCompany.Models;
using System;

namespace ProjectCompany.DpContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // DbContextOptions => Take Data Connection
        }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<WorksFor> worksFors { get; set; }
    }
}
