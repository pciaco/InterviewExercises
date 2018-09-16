using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public abstract class Product  
    {
        private string name;
        private double price;
        private int qta;
        protected bool isImported;
        protected double finalPrice;


        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Qta { get => qta; set => qta = value; }
        public bool IsImported { get => isImported; }
        public double FinalPrice { get => finalPrice; }

        protected abstract double getFinalPrice();

    }
}
