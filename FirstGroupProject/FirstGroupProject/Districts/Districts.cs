using FirstGroupProject.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.Districts
{
    class Districts
    {
        // TODO: add collection of Stores
        // TODO: ability to add District Manager
        public DistrictType DistrictHouse { get; set; }
        public string DistrictManager { get; set; }

        public Districts(DistrictType districtHouse, string districtManager)
        {
            DistrictHouse = districtHouse;
            DistrictManager = districtManager;
        }

    }
}
