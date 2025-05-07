namespace BO;

public class Sale
{
    public static int NextId { get; set; } = 3000;
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

    public override string ToString()
    {
        return string.Format("product-id=", ProductId, " amount=", Amount, " total-price=", TotalPrice, " for-club-customers=", ForClubCustomers, " sale-start-date=", SaleStartDate
            , " sale-end-date=", SaleEndDate, " id=", Id);
    }
}
