using CodeFirstCrud.Models;
using System.Collections.Generic;

namespace CodeFirstCrud.DataAccess
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
    }
}
