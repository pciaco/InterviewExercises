using SalesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace WcfSalesService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice, nel file svc e nel file di configurazione contemporaneamente.
    // NOTA: per avviare il client di prova WCF per testare il servizio, selezionare Service1.svc o Service1.svc.cs in Esplora soluzioni e avviare il debug.
    public class SalesServices : ISalesServices
    {
        public string addProduct(ProductInput product)
        {
            ReceiptManager.Instance.addProduct(product.Name, product.Price, product.Quantity, product.IsImported, product.IsTaxed);
            return "SUCCESS";
        }

        public string clearReceipt()
        {
            ReceiptManager.Instance.clearReceipt();
            return "SUCCESS";
        }

        public double total()
        {
            return ReceiptManager.Instance.getTotal();
        }

        public double totalTax()
        {
            return ReceiptManager.Instance.getTotalTax();
        }

        public List<ProductOutput> products()
        {
            List<Product> products = ReceiptManager.Instance.getProducts();
            List<ProductOutput> productsOutput = new List<ProductOutput>();
            foreach(Product p in products)
            {
                ProductOutput pO = new ProductOutput(p);
                productsOutput.Add(pO);
            }
            return productsOutput;
        }

        //public string addProductOptions(ProductInput product)
        //{
        //    return "";
        //}
    }
}
