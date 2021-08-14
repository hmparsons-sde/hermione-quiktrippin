using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.StoreSales
{
    class Sale
    {
        private string storeNumber;

        public int SaleId { get; set; }
        public int StoreNumber { get; set; }
        public int GasYearly { get; set; }
        public int GasCurrentQuarter { get; set; }
        public int RetailYearly { get; set; }
        public int RetailCurrentQuarter { get; set; }

        public Sale(string storeNumber, int gasYearly, int gasCurrentQuarter, int retailYearly, int retailCurrentQuarter)
        {
            this.storeNumber = storeNumber;
            GasYearly = gasYearly;
            GasCurrentQuarter = gasCurrentQuarter;
            RetailYearly = retailYearly;
            RetailCurrentQuarter = retailCurrentQuarter;
        }
        public class SalesWizard : SalesBase
        {
            public Dictionary<int, Sale> SalesDictionary { get; set; } = new Dictionary<int, Sale>();
        }
    }

}
