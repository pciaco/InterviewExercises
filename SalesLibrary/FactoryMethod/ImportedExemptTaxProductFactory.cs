using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class ImportedExemptTaxProductFactory : IProductFactory
    {
        private static ImportedExemptTaxProductFactory instance = null;

        private ImportedExemptTaxProductFactory()
        {
        }

        public static ImportedExemptTaxProductFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportedExemptTaxProductFactory();
                }
                return instance;
            }
        }
        public Product createProduct(string name, double price, int qta)
        {
            return new ExemptTaxProduct(name, price, qta, true);
        }
    }
}
