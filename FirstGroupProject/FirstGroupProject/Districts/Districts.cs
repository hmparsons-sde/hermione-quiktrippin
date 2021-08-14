using FirstGroupProject.Districts;
using FirstGroupProject.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.Districts
{
    public class District
    {
        // TODO: add collection of Stores
        // TODO: ability to add District Manager
        public DistrictType DistrictHouse { get; set; }
        public string DistrictManager { get; set; }

        //public List<Store> DistrictStores { get; set; }

        public District(DistrictType district)
        {
            //var districtName = district.ToString();
            //var districtStores = new StoreRepository();
            //var storesInDistrict = districtStores.GetAll().Where(s => s.DistrictHouse == district.ToString()).ToList();
            //foreach (Store s in storesInDistrict)
            //{
            //    Console.WriteLine($"Store {s.StoreNumber} is in {s.DistrictHouse}. The store manager is {s.StoreManager.Name}");
            //}

        }

    }
}
