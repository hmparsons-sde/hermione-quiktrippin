using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGroupProject.StoreSales
{
    class StoreSalesClass
    {
        //Sales for Store #518

        //Gas Yearly: $1,037,648
        //Gas Current quarter: $96,117
        //Retail Yearly: $1,823,294
        //Retail Current quarter: $84,445
        public string StoreManager { get; set; }
        public short GasYearly { get; set; }
        public short GasCurrentQuarter { get; set; }
        public short RetailYearly { get; set; }
        public short RetailCurrentQuarter { get; set; }

        public StoreSalesClass (string storeManager, short gasYearly, short gasCurrentQuarter, short retailYearly, short retailCurrentQuarter)
        {
            StoreManager = storeManager;
            GasYearly = gasYearly;
            GasCurrentQuarter = gasCurrentQuarter;
            RetailYearly = retailYearly;
            RetailCurrentQuarter = retailCurrentQuarter;
        }
    }

}
