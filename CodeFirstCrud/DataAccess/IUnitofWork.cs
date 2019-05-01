namespace CodeFirstCrud.DataAccess
{
    public interface IUnitofWork
    {
        IEmployeeRepository EmployeeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }

        void SaveChanges();
        void Dispose();
    }
}