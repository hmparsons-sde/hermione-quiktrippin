using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.Employees
{
    class EmployeeRepository
    {
        static List<Employee> _employees = new List<Employee>
        {
            new Employee("Rob Cole", JobType.StoreManager.ToString()),
            new Employee("Katy Fry", JobType.StoreManager.ToString()),
            new Employee("Holly Parsons", JobType.StoreManager.ToString()),
            new Employee("Wolf Crumbley", JobType.StoreManager.ToString())

        };

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
