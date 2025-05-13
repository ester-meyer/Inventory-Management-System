using DalApi;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class SaleImplementation : ISale
{
    private const string saleFilePath = @"..\xml\sales.xml";

    private List<Sale> loadSales()
    {
        List<Sale> sales;
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        using (StreamReader sw = new StreamReader(saleFilePath))
        {
            sales = (List<Sale>)serializer.Deserialize(sw);
        }
        return sales;
    }


    private void saveSales(List<Sale> sales)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        using (StreamWriter sw = new StreamWriter(saleFilePath))
        {
            serializer.Serialize(sw, sales);
        }
    }

    public int Create(Sale item)
    {
        List<Sale> sales = loadSales();
        sales.Add(item);
        saveSales(sales);
        return item.Id;
    }

    public void Delete(int id)
    {
        List<Sale> sales = loadSales();
        sales.RemoveAll(p => p.Id == id);
        saveSales(sales);
    }

    public Sale Read(int id)
    {
        List<Sale> sales = loadSales();
        return sales.Find(p => p.Id == id);
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        List<Sale> sales = loadSales();
        return sales.Find(s => filter(s));
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        if(filter == null)
            return loadSales();
        return loadSales().FindAll(s => filter(s));
    }

    public void Update(Sale item)
    {
        List<Sale> sales = loadSales();
        sales.RemoveAll(s => s.Id == item.Id);
        sales.Add(item);
        saveSales(sales);
    }
}

