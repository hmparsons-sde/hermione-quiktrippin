using FirstGroupProject.DistrictsRepository;
using FirstGroupProject.Employees;
using FirstGroupProject.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.BaseRepository
{
    public class RepositoryBase
    {
        class DistrictRepository
        {

            // we're using a static list here instead of a proper database
            // but the general idea still holds up once we cover databases
            // it's just another piece of code to replace and refactor nbd
            static List<Districts> _districts = new List<Districts>();

            public List<Districts> GetDistricts()
            {
                throw new NotImplementedException();
            }

            public void SaveNewDistrict(Districts district)
            {
                throw new NotImplementedException();
            }
        }
        class StoreRepository
        {

            static List<Stores.Stores> _stores = new List<Stores.Stores>();

            public List<Stores.Stores> GetStores()
            {
                throw new NotImplementedException();
            }
            public void SaveNewStore(Stores.Stores store)
            {
                throw new NotImplementedException();
            }
        }
        class EmployeeRepository
        {

            static List<Employee> _employees = new List<Employee>();

            public List<Employee> GetEmployees()
            {
                throw new NotImplementedException();
            }
        }
    }
}