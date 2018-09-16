using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class ImportedTaxedProductFactory : IProductFactory
    {
        private static ImportedTaxedProductFactory instance = null;

        private ImportedTaxedProductFactory()
        {
        }

        public static ImportedTaxedProductFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportedTaxedProductFactory();
                }
                return instance;
            }
        }
        public Product createProduct(string name, double price, int qta)
        {
            return new TaxedProduct(name, price, qta, true);
        }
    }
}
