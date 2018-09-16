using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public interface IProductFactory
    {
        Product createProduct(string name, double price, int qta);

       
    }
}
