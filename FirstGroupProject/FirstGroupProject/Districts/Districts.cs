using System.Collections.Generic;

namespace FirstGroupProject.DistrictsRepository
{
    class Districts
    {
        public short DistrictNumber { get; set; }
        public string DistrictManager { get; set; }

        public Districts(short districtNumber, string districtManager)
        {
            DistrictNumber = districtNumber;
            DistrictManager = districtManager;
        }
        //public List<Stores.Stores> GetStoreNumbers() => 
    }
}
