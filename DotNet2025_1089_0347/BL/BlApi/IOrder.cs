


namespace BlApi;

public interface IOrder
{
    int Create(BO.Order item);

    bool AddProduct(int productId, int amount);
    double CalcTotalPrice();
    void CalcProductTotalPrice(BO.ProductInOrder product);
    bool Handling();
    public void SearchSaleForProduct(bool isClubCustomer, BO.ProductInOrder product);
}
