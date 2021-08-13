using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstGroupProject.Districts;

namespace FirstGroupProject.Stores
{
    class Stores
    {
        //TODO: add a group of associates, store manager and assistant manager. 
        public int StoreNumber { get; set; }
        public DistrictType DistrictHouse { get; set; }

        public Stores(int storeNumber, DistrictType districtHouse)
        {
            StoreNumber = storeNumber;
            DistrictHouse = districtHouse;
        }

    }
}
