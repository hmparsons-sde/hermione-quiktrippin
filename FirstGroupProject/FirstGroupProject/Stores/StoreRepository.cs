using FirstGroupProject.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.Stores
{
    class StoreRepository
    {
        static List<Store> _stores = new List<Store>
        {
            new Store {StoreNumber = 432, DistrictHouse = Districts.DistrictType.Ravenclaw.ToString(), StoreManager = new Employee("Luna Lovegood", JobType.StoreManager.ToString()), 
                AssistantManager = new Employee("Hedwig", JobType.AssistantManager.ToString()), Associate = new Employee("Katy", JobType.Associate.ToString())},

            new Store {StoreNumber = 975, DistrictHouse = Districts.DistrictType.Hufflepuff.ToString(), StoreManager = new Employee("Arry Pottah", JobType.StoreManager.ToString()),
                AssistantManager = new Employee("HerMIOne", JobType.AssistantManager.ToString()), Associate = new Employee("Rob", JobType.Associate.ToString())},

            new Store {StoreNumber = 525, DistrictHouse = Districts.DistrictType.Gryffindor.ToString(), StoreManager = new Employee("Neville Longbottom", JobType.StoreManager.ToString()), 
                AssistantManager = new Employee("Ron WEAsley", JobType.AssistantManager.ToString()), Associate = new Employee("Holly", JobType.Associate.ToString())},

            new Store {StoreNumber = 666, DistrictHouse = Districts.DistrictType.Slytherin.ToString(), StoreManager = new Employee("Snape Snape Severus Snapeeee", JobType.StoreManager.ToString()),
                AssistantManager = new Employee("R U Sirius", JobType.AssistantManager.ToString()), Associate = new Employee("Mitchell", JobType.Associate.ToString())}
        };

        public List<Store> GetAll()
        {
            return _stores;
        }

        public void Add(Store store)
        {
            _stores.Add(store);
        }
    }
}
