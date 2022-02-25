using Demo_WebAppClass_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_WebAppClass_1.DBContexts
{


    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
          : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Manager { get; set; }
    }
}


