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
        public string JobTitle { get; set; }
        public int StoreNumber { get; set; }
        public short RetailSales { get; }

        public Employee(string name, string jobTitle, int storeNumber, short retailSales)
        {
            Name = name;
            JobTitle = jobTitle;
            StoreNumber = storeNumber;
            RetailSales = retailSales;
        }
    }
}
