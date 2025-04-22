using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder : Product
    {
        public int AmountInOrder { get; set; }
        public List<Sale> SalesForProduct { get; set; }
        public double FinalPrice { get; set; }

        public ProductInOrder(DO.Product product): base(product.Name ,(Categories)(int)product.Category ,product.Price ,product.AmountInStock,product.Id)
        {
            SalesForProduct = new List<Sale>();
            FinalPrice = 0;
        }

    }
}
