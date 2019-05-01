using System.Collections.Generic;
using System.Linq;
using CodeFirstCrud.Context;
using CodeFirstCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstCrud.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public void Create(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void Delete(int id)
        {
            Employee employee = Get(id);
            _context.Employees.Remove(employee);
        }

        public Employee Get(int id)
        {
            return _context.Employees
                .Include(e => e.Department)
                .FirstOrDefault(e => e.Id == id);
        }

        public ICollection<Employee> GetAll()
        {
            return _context.Employees
                .Include(e => e.Department)
                .ToList();
        }

        public void Update(Employee employee)
        {
            Employee entity = _context.Employees.FirstOrDefault(e => e.Id == employee.Id);

            entity.FirstName = employee.FirstName;
            entity.LastName = employee.LastName;
            entity.Email = employee.Email;
            entity.Single = employee.Single;
            entity.DepartmentId = employee.DepartmentId;

            _context.Employees.Update(entity);
        }
    }
}
