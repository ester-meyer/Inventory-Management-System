using DO;
using System.Xml.Linq;

namespace Dal;

internal class CustomerImplementation : DalApi.ICustomer
{
    const string CUSTOMER = "Customer";
    const string ID = "Id";

    private const string customerFilePath = @"..\xml\customers.xml";
    private Customer Convert(XElement customer)
    {
        return new Customer
        {
            Id = (int)customer.Element(ID),
            Address = (string)customer.Element("Address"),
            Name = (string)customer.Element("Name"),
            PhoneNumber = (string)customer.Element("PhoneNumber")
        };
    }

    private XElement loadList()
    {
        return XElement.Load(customerFilePath);
    }

    public int Create(Customer item)
    {
        XElement xmlCustomerList = loadList();
        XElement productElement = new XElement(CUSTOMER);
        foreach (var property in typeof(Product).GetProperties())
        {
            productElement.Add(new XElement(property.Name, property.GetValue(item)));
        }
        xmlCustomerList.Add(productElement);
        xmlCustomerList.Save(customerFilePath);
        return item.Id;
    }

    public void Delete(int id)
    {
        XElement xmlCustomerList = loadList();
        xmlCustomerList.Descendants(CUSTOMER).First(c => (int)c.Element(ID) ==id).Remove();
        xmlCustomerList.Save(customerFilePath) ;
    }

    public Customer Read(int id)
    {
        XElement xmlCustomerList = loadList();
        XElement customer = xmlCustomerList.Descendants(CUSTOMER).FirstOrDefault(c => (int)c.Element(ID) == id);
        return Convert(customer);
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        XElement xmlCustomerList = loadList();
        
        XElement customer = xmlCustomerList.Descendants(CUSTOMER).FirstOrDefault(c =>
        {
            var customer = Convert(c); // המרת العنصر ל- Customer - מהGPT :)
            return filter(customer); // החלת הפילטר על הלקוח
        });
        return Convert(customer);

    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        XElement xmlCustomerList = loadList();
        List<Customer?> customerList = xmlCustomerList.Descendants(CUSTOMER).Select(c => Convert(c)).ToList();
        if (filter != null)
            return customerList.Where(c => filter(c)).ToList();
        return customerList;
    }

    public void Update(Customer item)
    {
        Delete(item.Id);
        Create(item);
    }
}