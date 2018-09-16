using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class NotImportedTaxedProductFactory : IProductFactory
    {
        private static NotImportedTaxedProductFactory instance = null;

        private NotImportedTaxedProductFactory()
        {
        }

        public static NotImportedTaxedProductFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotImportedTaxedProductFactory();
                }
                return instance;
            }
        }
        public Product createProduct(string name, double price, int qta)
        {
            return new TaxedProduct(name, price, qta, false);
        }
    }
}
