using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int AmountInOrder { get; set; }
        public List<Sale> SalesForProduct { get; set; }
        public double FinalPrice { get; set; }

        public Product Product { get; set; }

        public ProductInOrder(Product product, int amountInOrder)
        {
            Product = product;
            AmountInOrder = amountInOrder;
            SalesForProduct = new List<Sale>();
            FinalPrice = 0;
        }

    }
}
