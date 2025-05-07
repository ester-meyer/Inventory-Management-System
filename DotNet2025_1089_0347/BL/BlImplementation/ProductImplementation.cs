
using BlApi;
using System.Linq;

namespace BlImplementation;

internal class ProductImplementation : BlApi.IProduct
{

    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Product item)
    {
        try
        {
            DO.Product product = BO.Tools.Convert<BO.Product, DO.Product>(item);//how to use it by extention method
            return _dal.Product.Create(product);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public BO.Product Read(int id)
    {
        try
        {
            return BO.Tools.Convert<DO.Product, BO.Product>(_dal.Product.Read(id));
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        try
        {
            return _dal.Product.ReadAll().Select(BO.Tools.Convert<DO.Product, BO.Product>).FirstOrDefault(filter);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public List<BO.Product?> ReadAll(Func<DO.Product, bool>? filter = null)
    {
        try
        {
            List<DO.Product> doProducts = _dal.Product.ReadAll(filter);
            List<BO.Product> boProducts = doProducts.Select(BO.Tools.Convert<DO.Product, BO.Product>).ToList();
            return boProducts;
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }


    public void Update(BO.Product item)
    {
        try
        {
            DO.Product product = BO.Tools.Convert<BO.Product, DO.Product>(item);
            _dal.Product.Update(product);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }
}
