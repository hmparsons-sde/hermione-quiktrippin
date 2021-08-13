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
        public short GasYearly { get; set; }
        public short GasCurrentQuarter { get; set; }
        public short RetailYearly { get; set; }
        public short RetailCurrentQuarter { get; set; }

        public Sale(int saleId, int storeNumber, short gasYearly, short gasCurrentQuarter, short retailYearly, short retailCurrentQuarter)
        {
            SaleId = saleId;
            StoreNumber = storeNumber;
            GasYearly = gasYearly;
            GasCurrentQuarter = gasCurrentQuarter;
            RetailYearly = retailYearly;
            RetailCurrentQuarter = retailCurrentQuarter;
        }

        public Sale(string storeNumber, short gasYearly, short gasCurrentQuarter, short retailYearly, short retailCurrentQuarter)
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
