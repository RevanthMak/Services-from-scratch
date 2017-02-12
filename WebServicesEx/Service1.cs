using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServicesEx
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        
        public void DeleteEmployee(int id, string name)
        {
            
        }

        
        public Employee GetEmployee(int id)
        {
            return null;

            
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return emp;
        }

        public void UpdateEmployee(int id)
        {
            
        }


        List<Employee> emp = new List<Employee>
        {
            new Employee() { Id =1, Name = "Name 1", Dept = "Dept 1", Date = DateTime.Now },
            new Employee() { Id =2, Name = "Name 2", Dept = "Dept 2", Date = DateTime.Now },
            new Employee() { Id =3, Name = "Name 3", Dept = "Dept 3", Date = DateTime.UtcNow },
            new Employee() { Id =4, Name = "Name 4", Dept = "Dept 4", Date = DateTime.Now },
            new Employee() { Id =5, Name = "Name 5", Dept = "Dept 5", Date = DateTime.UtcNow },
        };
    }

    
}
