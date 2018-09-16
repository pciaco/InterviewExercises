using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class ExemptTaxProduct : Product
    {
        public ExemptTaxProduct(string name, double price, int qta, bool isImported)
        {
            this.Name = name;
            this.Price = price;
            this.Qta = qta;
            this.isImported = isImported;
            this.finalPrice = getFinalPrice();
        }
        protected override double getFinalPrice()
        {
            double fP = Price * Qta;
            if (IsImported) fP += Price / 100 * 5;
            return Math.Round(fP, 2);
        }
    }

    
}
