using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public enum ProductType{
        ImportedTaxedProduct,
        NotImportedTaxedProduct,
        ImportedExemptTaxProduct,
        NotImportedExemptTaxProduct
    }
    public class ReceiptManager
    {
        private static ReceiptManager instance = null;

        private ReceiptManager()
        {
        }

        public static ReceiptManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptManager();
                }
                return instance;
            }
        }
        private List<Product> products = new List<Product>();
        private double total = 0;
        private double totalTax = 0;
        public void addProduct(string name, double price, int qta, bool isImported, bool isTaxed)
        {
            Product product = null;
            ProductType productType = setProductType(isImported, isTaxed);
            switch (productType)
            {
                case ProductType.ImportedTaxedProduct:
                    product = ImportedTaxedProductFactory.Instance.createProduct(name, price, qta);                   
                    break;
                case ProductType.NotImportedTaxedProduct:
                    product = NotImportedTaxedProductFactory.Instance.createProduct(name, price, qta);
                    break;
                case ProductType.ImportedExemptTaxProduct:
                    product = ImportedExemptTaxProductFactory.Instance.createProduct(name, price, qta);
                    break;
                case ProductType.NotImportedExemptTaxProduct:
                    product = NotImportedExemptTaxProductFactory.Instance.createProduct(name, price, qta);
                    break;
            }
            total += product.FinalPrice;
            totalTax += product.FinalPrice - price;
            totalTax = Math.Round(totalTax, 2);
            products.Add(product);
        }

        public List<Product> getProducts()
        {
            return products;
        }
        public double getTotal()
        {
            return this.total;
        }

        public double getTotalTax()
        {
            return this.totalTax;
        }

        public void clearReceipt()
        {
            this.products = new List<Product>();
            this.total = 0;
            this.totalTax = 0;
        }
        private ProductType setProductType(bool isImported, bool isTaxed)
        {
            if (isImported)
            {
                if (isTaxed) return ProductType.ImportedTaxedProduct;
                else return ProductType.ImportedExemptTaxProduct;
            }
            else
            {
                if (isTaxed) return ProductType.NotImportedTaxedProduct;
                else return ProductType.NotImportedExemptTaxProduct;
            }
        }
        
    }
}
