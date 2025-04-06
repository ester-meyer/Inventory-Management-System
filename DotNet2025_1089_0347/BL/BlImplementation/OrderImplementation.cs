using System.Diagnostics;
using System.Xml.Linq;

namespace BlImplementation;

internal class OrderImplementation : BlApi.IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;


    public void CalcProductTotalPrice(BO.ProductInOrder product)
    {
        int count = product.AmountInOrder;
        double totalPrice = 0;
        List<BO.Sale> salesUsed = new List<BO.Sale>();
        foreach (BO.Sale sale in product.SalesForProduct)
        {
            if (count < sale.Amount)
            {
                continue;
            }

            int timesUseSale = (count / sale.Amount); // times to use sale
            totalPrice += (timesUseSale * sale.TotalPrice); // add to total price
            count -= timesUseSale * sale.Amount; // update amount

            salesUsed.Add(sale); // sales used

            if (count == 0)
            {
                break; // if products finished
            }
        }
        totalPrice += (count * product.Price); // products not with sale
        product.SalesForProduct = salesUsed;
        product.FinalPrice = totalPrice;
    }

    public void SearchSaleForProduct(bool isClubCustomer, BO.ProductInOrder product)
    {
        DateOnly now = DateOnly.FromDateTime(DateTime.Now);
        product.SalesForProduct = _dal.Sale.ReadAll()
            .Select(BO.Tools.Convert<DO.Sale, BO.Sale>)
            .Where(s => s.ProductId == product.Id &&
                        s.SaleStartDate < now &&
                        s.SaleEndDate > now &&
                        product.AmountInOrder >= s.Amount &&
                        (isClubCustomer || s.ForClubCustomers == false))
            .OrderBy(s => (s.TotalPrice / s.Amount))
            .ToList();

    }
    public void CalcTotalPrice(BO.Order item)
    {
        item.TotalPrice = item.Products.Sum(p => p.FinalPrice);
    }
    public List<BO.Sale> AddProductToOrder(BO.Order item, int productId, int amount)
    {
        DO.Product DoProduct= _dal.Product.ReadAll().First(p => p.Id == productId);
        int? amountInStock = DoProduct.AmountInStock;  //get anount in stock of product
        BO.ProductInOrder? productInOrder = item.Products.FirstOrDefault(p => p.Id == productId);  //get the product from ordet if exists in the order
        if ( productInOrder == null )
        {
            productInOrder = new BO.ProductInOrder(DoProduct);
            if(amountInStock >= amount)
                item.Products.Add(productInOrder);
        }
        productInOrder.AmountInOrder += amount;
        if (amountInStock < productInOrder.AmountInOrder)
            throw new Exception($"Product not in stock.\n Only {amountInStock} in stock.");
        SearchSaleForProduct(item.IsClubCustomer, productInOrder);
        CalcProductTotalPrice(productInOrder);
        CalcTotalPrice(item);
        return productInOrder.SalesForProduct;
    }

    public void DoOrder(BO.Order item)
    {
        foreach(BO.ProductInOrder productInOrder in item.Products)
        {
            BO.Product p = productInOrder;
            p.AmountInStock -= productInOrder.AmountInOrder;
            _dal.Product.Update(BO.Tools.Convert<BO.Product,DO.Product>(p));
        }
    }
}
