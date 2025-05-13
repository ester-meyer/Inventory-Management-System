

using BO;

namespace BlApi;

public interface IProduct
{
    Product Read(int id);
    int Create(Product item);
    Product? Read(Func<Product, bool> filter);
    List<Product?> ReadAll(Func<DO.Product, bool>? filter = null);
    void Update(Product item);
    void Delete(int id);
}
