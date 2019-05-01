using CodeFirstCrud.Models;
using System.Collections.Generic;

namespace CodeFirstCrud.DataAccess
{
    public interface IEmployeeRepository
    {
        ICollection<Employee> GetAll();
        Employee Get(int id);

        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
