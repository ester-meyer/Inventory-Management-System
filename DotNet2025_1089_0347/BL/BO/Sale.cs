using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int? ProductId { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public bool? ForClubCustomers { get; set; }
        public DateOnly? SaleStartDate { get; set; }
        public DateOnly? SaleEndDate { get; set; }
        public int? Id { get; init; }
        public override string ToString()
        {
            return string.Format("product-id=", ProductId, " amount=", Amount, " total-price=", TotalPrice, " for-club-customers=", ForClubCustomers," sale-start-date=", SaleStartDate
                ," sale-end-date=",SaleEndDate," id=", Id);
        }
    }
}
