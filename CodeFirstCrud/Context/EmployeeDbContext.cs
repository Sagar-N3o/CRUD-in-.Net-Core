using CodeFirstCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstCrud.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
