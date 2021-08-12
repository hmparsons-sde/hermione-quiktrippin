using FirstGroupProject.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.Employees
{
    public class Employee : RepositoryBase
    {
        // creating class to iterate upon 
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public int StoreNumber { get; set; }
        public short RetailSales { get; set; }

        //public Employee(string name, string jobTitle, int storeNumber, short retailSales)
        //{
        //    Name = name;
        //    JobTitle = jobTitle;
        //    StoreNumber = storeNumber;
        //    RetailSales = retailSales;
        //}

        static List<Employee> _employee = new List<Employee>
        {
            new Employee{Name="Hagrid", JobTitle="DistrictManager", StoreNumber=823, RetailSales=4314 },
            new Employee{Name="Luna Lovegood", JobTitle="Store Manager", StoreNumber=813, RetailSales=1234 },
            //new Employee("Nevil Longbottom", "Assistant to the Regional Manager", 823, 6578),
            //new Employee("Arry Potuh", "Associate", 823, 924),
        };

        public void Add(Employee employee)
        {
            _employee.Add(employee);
        }

        public List<Employee> GetAll()
        {
            return _employee;
        }
        public List<Employee> ListEmployees(int storeNumber)
        {
            foreach (var employee in _employee)
            {
                if (employee.StoreNumber == storeNumber)
                {
                    Console.WriteLine(employee.Name);
                }
                else
                {
                    Console.WriteLine("No Employees at this store");
                }
            }
            return null;
        }

        public void Delete(string name)
        {
            var personToRemove = _employee.First(employee => employee.Name == name);

            _employee.Remove(personToRemove);
        }
    }
}
