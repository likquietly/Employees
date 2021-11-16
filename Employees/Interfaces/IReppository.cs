using System.Collections.Generic;

namespace Employees
{
    interface IReppository<T>
        where T : class
    {
        IEnumerable<T> GetEmployeeList();
        T GetEmployee(int id);
        void Create(T item);
        void Delete(int id);
    }
}