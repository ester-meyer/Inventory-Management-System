


namespace BlApi;

public interface IOrder
{
    List<BO.Sale> AddProductToOrder(BO.Order item, int productId, int amount);
    void CalcProductTotalPrice(BO.ProductInOrder product);
    void CalcTotalPrice(BO.Order item);
    void DoOrder(BO.Order item);
    void SearchSaleForProduct(bool isClubCustomer, BO.ProductInOrder product);
}
