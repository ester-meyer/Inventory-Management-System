namespace BlApi;

public interface IBl
{
    public ICustomer Customer { get; }
    public IProduct Product { get; }
    public IOrder Order { get; }
    public ISale Sale { get; }

}