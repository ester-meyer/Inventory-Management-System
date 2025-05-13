
namespace BlImplementation;

internal class SaleImplementation : BlApi.ISale
{

    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Sale item)
    {
        try
        {
            DO.Sale sale = BO.Tools.Convert<BO.Sale, DO.Sale>(item);
            return _dal.Sale.Create(sale);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public bool CustomerExists(int id)
    {
        try
        {
            return (Read(id) != null);
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
            _dal.Sale.Delete(id);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public BO.Sale Read(int id)
    {
        try
        {
            return BO.Tools.Convert<DO.Sale, BO.Sale>(_dal.Sale.Read(id));
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try
        {
            return _dal.Sale.ReadAll().Select(BO.Tools.Convert<DO.Sale, BO.Sale>).FirstOrDefault(filter);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public List<BO.Sale?> ReadAll(Func<DO.Sale, bool>? filter = null)
    {
        try
        {
            return _dal.Sale.ReadAll(filter).Select(BO.Tools.Convert<DO.Sale, BO.Sale>).ToList();

        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public void Update(BO.Sale item)
    {
        try
        {
            DO.Sale sale = BO.Tools.Convert<BO.Sale, DO.Sale>(item);
            _dal.Sale.Update(sale);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }
}
