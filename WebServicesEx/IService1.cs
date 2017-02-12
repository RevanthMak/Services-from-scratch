using System.Collections.Generic;
using System.ServiceModel;

namespace WebServicesEx
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 
    {
        [OperationContract]
        IEnumerable<Employee> GetEmployees();

        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        void UpdateEmployee(int id);

        [OperationContract]
        void DeleteEmployee(int id, string name);
    }
}
