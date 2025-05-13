using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public int CustomerId { get; set; }
        public bool IsClubCustomer { get; set; }
        public List<ProductInOrder> Products { get; set; }
        public double TotalPrice { get; set; }
        public Order(int customerId, bool isClubCustomer)
        {
            CustomerId = customerId;
            IsClubCustomer = isClubCustomer;
            Products = new List<ProductInOrder>();
            TotalPrice = 0;
        }
        public Order() { }
        public override string ToString()
        {
            return string.Format("customer-id=", CustomerId, " is-new-customer=", IsNewCusotmer, " products=", Products, " totol-price=", TotalPrice);
        }
    }
}
