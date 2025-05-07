using DalApi;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplementation : IProduct
{
    private const string productFilePath = @"..\xml\products";

    List<Product> products ;

    public List<Product> loadProducts()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        using (StreamReader sw = new StreamReader(productFilePath))
        {
            products =  (List<Product>)serializer.Deserialize(sw);
        }
        return products; 
    }


    public void saveProduct()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        using(StreamWriter sw = new StreamWriter(productFilePath))
        {
            serializer.Serialize(sw, products);
        }
    }


    public int Create(Product item)
    {
        products.Add(item);
        saveProduct();
        return item.Id;
    }

    public void Delete(int id)
    {
        products.RemoveAll(p => p.Id == id);
        saveProduct();
    }

    public Product Read(int id)
    {
        return products.Find(p => p.Id == id);
    }

    public Product? Read(Func<Product, bool> filter)
    {
        return products.Find(p => filter(p));
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        if (filter == null)
            return loadProducts();
        return loadProducts().FindAll(p =>   filter(p));
    }

    public void Update(Product item)
    {
        
        products.RemoveAll(p => p.Id == item.Id);
        products.Add(item);
        saveProduct();
    }
}
