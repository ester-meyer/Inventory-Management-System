
using BlApi;

namespace BlImplementation;

internal class CustomerImplementation : BlApi.ICustomer
{

    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer item)
    {
        try
        {
            DO.Customer customer = BO.Tools.Convert<BO.Customer, DO.Customer>(item);//how to use it by extention method
            return _dal.Customer.Create(customer);
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
            _dal.Customer.Delete(id);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public BO.Customer Read(int id)
    {
        try
        {
            return BO.Tools.Convert<DO.Customer, BO.Customer>(_dal.Customer.Read(id));
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public BO.Customer? Read(Func<DO.Customer, bool> filter)
    {
        try
        {
            return _dal.Customer.ReadAll(filter).Select(BO.Tools.Convert<DO.Customer, BO.Customer>).FirstOrDefault();//Read(Func<Customer, bool> filter) in DO is not used
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public List<BO.Customer> ReadAll(Func<DO.Customer, bool>? filter = null)
    {
        try
        {
            return  _dal.Customer.ReadAll(filter).Select(BO.Tools.Convert<DO.Customer, BO.Customer>).ToList();
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }

    public void Update(BO.Customer item)
    {
        try
        {
            DO.Customer customer = BO.Tools.Convert<BO.Customer, DO.Customer>(item);
            _dal.Customer.Update(customer);
        }
        catch (Exception DoException)
        {
            throw DoException;
        }
    }


}


