using CodeFirstCrud.Context;
using System;

namespace CodeFirstCrud.DataAccess
{
    public class UnitofWork : IDisposable, IUnitofWork
    {
        private readonly EmployeeDbContext _context;
        public IEmployeeRepository EmployeeRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }

        public UnitofWork(EmployeeDbContext context)
        {
            _context = context;
            EmployeeRepository = new EmployeeRepository(_context);
            DepartmentRepository = new DepartmentRepository(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                _context.Dispose();
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
