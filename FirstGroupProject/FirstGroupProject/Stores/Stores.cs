using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstGroupProject.Districts;
using FirstGroupProject.Employees;

namespace FirstGroupProject.Stores
{
    public class Store
    {

        public int StoreNumber { get; set; }
        public string DistrictHouse { get; set; }
        public Employee Associate { get; set; }
        public Employee StoreManager { get; set; }
        public Employee AssistantManager { get; set; }
    }
}
