using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.Employees
{
    public class Employee
    {
        // creating class to iterate upon 
        public string Name { get; set; }
        public JobType JobTitle { get; set; }
        public int StoreNumber { get; set; }
        public short RetailSales { get; set; }

        public Employee(string name, JobType jobTitle, int storeNumber, short retailSales)
        {
            Name = name;
            JobTitle = jobTitle;
            StoreNumber = storeNumber;
            RetailSales = retailSales;
        }

        public Employee(string name, JobType jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;

        }

        //    static List<Employee> _employee = new List<Employee>();

        //    public List<Employee> GetEmployees()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Add(Employee employee)
        //    {
        //        _employee.Add(employee);
        //    }

        //    public List<Employee> GetAll()
        //    {
        //        return _employee;
        //    }
        //}


        //public List<Employee> ListEmployees(int storeNumber)
        //    {
        //        foreach (var employee in employee)
        //        {
        //            if (employee.StoreNumber == storeNumber)
        //            {
        //                Console.WriteLine(employee.Name);
        //            }
        //            else
        //            {
        //                Console.WriteLine("No Employees at this store");
        //            }
        //        }
        //        return null;
        //    }

        //    public void Delete(string name)
        //    {
        //        var personToRemove = _employee.First(employee => employee.Name == name);

        //        _employee.Remove(personToRemove);
        //    }
    }
}
