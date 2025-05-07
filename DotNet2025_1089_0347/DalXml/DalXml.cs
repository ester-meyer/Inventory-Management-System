using  DalApi;
namespace Dal
{
    internal class DalXml : IDal
    {
        public ICustomer Customer => new CustomerImplementation();

        public IProduct Product => new ProductImplementation();

        public ISale Sale => new SaleImplementation();
    }
}