


namespace BlImplementation;

internal class OrderImplementation : BlApi.IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public bool AddProduct(int productId, int amount)
    {
        throw new NotImplementedException();
    }

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

            int applicableTimes = (count / sale.Amount); // times to use sale
            totalPrice += (applicableTimes * sale.TotalPrice); // add to total price
            count -= applicableTimes * sale.Amount; // update amount

            salesUsed.Add(sale); // sales used

            if (count == 0)
            {
                break; // if products finished
            }
        }
        totalPrice += (count * product.Price);
        product.SalesForProduct=salesUsed;
        product.FinalPrice = totalPrice;
    }



    public double CalcTotalPrice()
    {
        throw new NotImplementedException();
    }


    public int Create(BO.Order item)
    {
        throw new NotImplementedException();
    }

    public bool Handling()
    {
        throw new NotImplementedException();
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
        int? amountInStock = _dal.Product.ReadAll().First(p => p.Id == productId).AmountInStock;//get anount in stock of product
        BO.ProductInOrder productInOrder = item.Products.First(p => p.Id == productId);//get the product from ordet if exists in the order
        if ( productInOrder != null )
        {
            if (amountInStock < amount)
                throw new Exception("product not in stock");
            else
            {
                productInOrder.AmountInOrder += amount;
                //update stock in DO.Product

            }
        }
        else
        {
            productInOrder = new BO.ProductInOrder();
            //productInOrder.Id = productId;
        }
        //SearchSaleForProduct(?, productInOrder);
        //SearchSaleForProduct(?,productInOrder);
        CalcTotalPrice(item);
        return productInOrder.SalesForProduct;
    }

    public void DoOrder(BO.Order item)
    {
        foreach(BO.ProductInOrder productInOrder in item.Products)
        {
            //_dal.Product.Update()
        }
    }
}




//4.	AddProductToOrder – הוספת מוצר להזמנה.
//מקבלת כפרמטרים: הזמנה, מזהה מוצר להוספה וכמות להוספה (יכולה להיות שלילית)
//מחזירה רשימת מבצעים שמומשו עבור מוצר זה בהזמנה זו.
//מימוש הפונקציה:
//שולפים את המוצר הנבחר מהזיכרון(פניה ל DAL)
//מנסים למצוא את המוצר הנבחר ברשימת המוצרים בהזמנה
//אם קיים – בודקים שלאחר הוספת הכמות המבוקשת, יש מספיק במלאי מהמוצר ומעדכנים את הכמות בהזמנה. (אם אין מספיק במלאי – זורקים שגיאה מתאימה)
//אם המוצר עדיין לא קיים בהזמנה, בודקים שיש במלאי את הכמות המבוקשת ומוסיפים מוצר חדש להזמנה(אם אין מספיק במלאי – זורקים שגיאה מתאימה)
//בודקים מה המבצעים הקיימים למוצר זה(SearchSalesForProduct)
//מחשבים את המחיר למוצר זה כולל מימוש המבצעים(CalcTotalPriceForProduct)
//מחשבים את המחיר הסופי להזמנה(CalcTotalPrice)
//מחזירים את רשימת המבצעים שמומשו.
//5.	DoOrder – מקבלת כפרמטר הזמנה ולא מחזירה ערך.
//עבור כל מוצר בהזמנה, מייצרים בקשת עדכון ל DAL כדי להוריד ממלאי המוצר את הכמות שב
