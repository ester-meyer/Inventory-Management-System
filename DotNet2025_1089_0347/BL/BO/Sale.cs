using System.Diagnostics;
using System.Xml.Linq;

namespace BO;

public class Sale
{
    public int? ProductId { get; set; }
    public int Amount { get; set; }
    public double TotalPrice { get; set; }
    public bool? ForClubCustomers { get; set; }
    public DateOnly? SaleStartDate { get; set; }
    public DateOnly? SaleEndDate { get; set; }
    public int? Id { get; init; }

    public Sale(int productId, int amount,double totalPrice,bool forClubCustomers,DateOnly start,DateOnly end)
    {
       ProductId=productId;
        Amount=amount;
        TotalPrice=totalPrice;
        ForClubCustomers=forClubCustomers;
        SaleStartDate=start;
        SaleEndDate=end;
    }
    public Sale()
    {
    }


}
