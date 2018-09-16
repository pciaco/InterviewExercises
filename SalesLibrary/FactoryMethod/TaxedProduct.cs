using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class TaxedProduct : Product
    {
        const int TAX = 10;
        public TaxedProduct(string name, double price, int qta, bool isImported)
        {
            this.Name = name;
            this.Price = price;
            this.Qta = qta;
            this.isImported = isImported;
            this.finalPrice = getFinalPrice();
        }
        protected override double getFinalPrice()
        {
            double tP = Price * Qta;
            double fP = tP + (tP / 100 * TAX);
            if (IsImported) fP += tP / 100 * 5;
            return Math.Round(fP,2);
        }
    }
}
