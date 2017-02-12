using System.Collections.Generic;

namespace WebServicesEx
{
    public interface CRUDOperations
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(int id);
        void UpdateEmployee(int id);
        void DeleteEmployee(int id, string name);
    }
}
