using System.Collections.Generic;
using System.Linq;
using CodeFirstCrud.Context;
using CodeFirstCrud.Models;

namespace CodeFirstCrud.DataAccess
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDbContext _context;

        public DepartmentRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }
    }
}
