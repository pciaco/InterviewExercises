using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class NotImportedExemptTaxProductFactory : IProductFactory
    {
        private static NotImportedExemptTaxProductFactory instance = null;

        private NotImportedExemptTaxProductFactory()
        {
        }

        public static NotImportedExemptTaxProductFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotImportedExemptTaxProductFactory();
                }
                return instance;
            }
        }
        public Product createProduct(string name, double price, int qta)
        {
            return new ExemptTaxProduct(name, price, qta, false);
        }
    }
}
