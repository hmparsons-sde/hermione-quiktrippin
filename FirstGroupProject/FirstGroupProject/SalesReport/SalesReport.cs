using FirstGroupProject.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.SalesReport
{
    class SalesReport
    {
        public string StroreNumber { get; set; }
        public string StoreManager { get; set; }
        public string AssistantManager { get; set; }
        public string Associate { get; set; }
        public string StoreSales { get; set; }

        public void DistrictSalesReport(string StoreNumber, string StoreManager, string AssistantManager, string Assocaites, string StoreSales)
        {
            Console.WriteLine("District Sales Report\n\x1B[4m\n");
            //Needs a function that will grab all the stores assocaites with a district.
            //Thinking of making a template for each store sales report taking in the info from a store and 
            //neartly arranging it
            Console.WriteLine("PENDING - Store Number\x1B[0m");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("PENDING - 1. Store Manager");
            Console.WriteLine("PENDING - Manager Name");
            Console.WriteLine("PENDING - Store Manager\n");


        }
    }
}

