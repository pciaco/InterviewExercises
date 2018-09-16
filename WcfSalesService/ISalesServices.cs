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
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface ISalesServices
    {

        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/addProduct")]
        string addProduct(ProductInput product);

        //[OperationContract]
        //[WebInvoke(Method = "OPTIONS",
        //   UriTemplate = "/addProduct")]
        //string addProductOptions(ProductInput product);

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        double total();

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        double totalTax();

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/products")]
        List<ProductOutput> products();

        [OperationContract]
        [WebInvoke(Method = "DELETE",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string clearReceipt();
    }


    // Per aggiungere tipi compositi alle operazioni del servizio utilizzare un contratto di dati come descritto nell'esempio seguente.
    [DataContract]
    public class ProductInput
    {
        string name;
        double price;
        int quantity;
        bool isImported;
        bool isTaxed;


        [DataMember]
        public bool IsImported
        {
            get { return isImported; }
            set { isImported = value; }
        }

        [DataMember]
        public bool IsTaxed
        {
            get { return isTaxed; }
            set { isTaxed = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }

    [DataContract]
    public class ProductOutput
    {
        string name;
        double price;
        int quantity;
        bool isImported;
        double finalPrice;

        public ProductOutput(Product p)
        {
            name = p.Name;
            price = p.Price;
            quantity = p.Qta;
            isImported = p.IsImported;
            finalPrice = p.FinalPrice;
        }

        [DataMember]
        public bool IsImported
        {
            get { return isImported; }
            set { isImported = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        [DataMember]
        public double FinalPrice
        {
            get { return price; }
            set { price = value; }
        }

        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
