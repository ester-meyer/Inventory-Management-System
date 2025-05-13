using DelTest;
using BO;
using System.Reflection;
using BlApi;

namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Initialization.Initialize();

            int select = printMainMenu();
            while (select != 0)
            {
                int subSelect;
                switch (select)
                {
                    case 1:
                        subSelect = printSubMenu<BlApi.IProduct>();
                        ProductImplementation(subSelect);
                        break;
                    case 2:
                        subSelect = printSubMenu<BlApi.ISale>();
                        SaleImplementation(subSelect);
                        break;
                    case 3:
                        subSelect = printSubMenu<BlApi.ICustomer>();
                        CustomerImplementation(subSelect);
                        break;
                    case 4:
                        BuildOrder();
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }

                select = printMainMenu();
            }
        }

        private static int printMainMenu()
        {
            Console.WriteLine("For product press 1");
            Console.WriteLine("For sale press 2");
            Console.WriteLine("For customrer press 3");
            Console.WriteLine("For order press 4");
            Console.WriteLine("To exit press 0");

            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;
        }
        private static int printSubMenu<T>()
        {
            int methodId = 1;
            MethodInfo[] methods = typeof(T).GetMethods();

            foreach (MethodInfo method in methods.OrderBy(m => m.Name))
            {
                //for printing id parameter by read - bug for more than one parameter dou to function First()
                Console.WriteLine($"for {method.Name}({method.GetParameters()
                    .Select(p => $"{p.Name}").First()}) press {methodId++} ");
            }
            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;
        }

        private static void SaleImplementation(int subSelect)
        {
            switch (subSelect)
            {
                case 1:
                    s_bl.Sale.Create(BuildSale());
                    break;
                case 2:
                    s_bl.Sale.Delete(GetId("Sale"));
                    break;
                case 3:
                    Console.WriteLine(s_bl.Sale.Read(GetId("sale")));
                    break;
                case 4:
                    Console.WriteLine(s_bl.Sale.Read(ChooseFilter<Sale>()));
                    break;
                case 5:
                    s_bl.Sale.ReadAll(ChooseFilter<DO.Sale>()).ForEach(s => Console.WriteLine(s.ToStringProperty()));
                    break;
                case 6:
                    s_bl.Sale.Update(BuildSale(GetId("sale")));
                    break;
                default:
                    Console.WriteLine("Wrong selection.");
                    break;
            }
        }
        private static void ProductImplementation(int subSelect)
        {
            switch (subSelect)
            {
                case 1:
                    s_bl.Product.Create(BuildProduct());
                    break;
                case 2:
                    s_bl.Product.Delete(GetId("product"));
                    break;
                case 3:
                    Console.WriteLine(s_bl.Product.Read(GetId("product")));
                    break;
                case 4:
                    Console.WriteLine(s_bl.Product.Read(ChooseFilter<Product>()));
                    break;
                case 5:
                    s_bl.Product.ReadAll().ForEach(p => Console.WriteLine(p.ToStringProperty()));
                    break;
                case 6:
                    s_bl.Product.Update(BuildProduct(GetId("product")));
                    break;
                default:
                    Console.WriteLine("Wrong selection.");
                    break;
            }
        }
        private static void CustomerImplementation(int subSelect)
        {
            switch (subSelect)
            {
                case 1:
                    s_bl.Customer.Create(BuildCustomer());
                    break;
                case 2:
                    s_bl.Customer.CustomerExists(GetId("customer"));
                    break;
                case 3:
                    s_bl.Customer.Delete(GetId("customer"));
                    break;
                case 4:
                    Console.WriteLine(s_bl.Customer.Read(GetId("customer")));
                    break;
                case 5:
                    Console.WriteLine(s_bl.Customer.Read(ChooseFilter<DO.Customer>()));
                    break;
                case 6:
                    s_bl.Customer.ReadAll().ForEach(c => Console.WriteLine(c.ToStringProperty()));
                    break;
                case 7:
                    s_bl.Customer.Update(BuildCustomer());
                    break;
                default:
                    Console.WriteLine("Wrong selection.");
                    break;
            }
        }

        private static Product BuildProduct(int id = 0)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            DO.Categories category;
            do
            {
                Console.WriteLine("enter category");

            } while (!Enum.TryParse(Console.ReadLine(), out category));

            double price;
            do
            {
                Console.WriteLine("enter price");
            } while (!double.TryParse(Console.ReadLine(), out price));

            int amountInStock;
            do
            {
                Console.WriteLine("enter amount in stock");
            } while (!int.TryParse(Console.ReadLine(), out amountInStock));

            return new Product(name, category, price, amountInStock) { Id = id };
        }
        private static Sale BuildSale(int id = 0)
        {
            int productId;
            do
            {
                Console.WriteLine("enter product id");
            } while (!int.TryParse(Console.ReadLine(), out productId));

            int amount;
            do
            {
                Console.WriteLine("enter amount");
            } while (!int.TryParse(Console.ReadLine(), out amount));

            double totalPrice;
            do
            {
                Console.WriteLine("enter total price");
            } while (!double.TryParse(Console.ReadLine(), out totalPrice));

            bool forClubCustomers;
            do
            {
                Console.WriteLine("is it for club customers? enter true/false");
            } while (!bool.TryParse(Console.ReadLine(), out forClubCustomers));

            DateOnly start;
            do
            {
                Console.WriteLine("enter start date");
            } while (!DateOnly.TryParse(Console.ReadLine(), out start));

            DateOnly end;
            do
            {
                Console.WriteLine("enter end date");
            } while (!DateOnly.TryParse(Console.ReadLine(), out end));

            return new Sale(productId, amount, totalPrice, forClubCustomers, start, end) { Id = id };
        }
        private static Customer BuildCustomer()
        {
            int id;
            do
            {
                Console.WriteLine("enter id");
            } while (!int.TryParse(Console.ReadLine(), out id));

            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter adderss");
            string address = Console.ReadLine();
            Console.WriteLine("enter phone-number");
            string phoneNumber = Console.ReadLine();

            return new Customer(id, name, address, phoneNumber);
        }
        private static Order BuildOrder()
        {
            int customerId;
            do
            {
                Console.WriteLine("enter customer id");
            } while (!int.TryParse(Console.ReadLine(), out customerId));
            Customer customer = s_bl.Customer.Read(customerId);
            if (customer == null)
            {
                //needs implement the exception
                throw new Exception("customer not found");
            }

            Order order = new Order(customerId, customer.IsClubCustomer);

            Console.WriteLine("--------Insert Products Details--------");
            string toExit = "";
            while (toExit != "exit")
            {
                ProductInOrder productInOrder = BuildProductInOrder(customer.IsClubCustomer);
                s_bl.Order.AddProductToOrder(order, productInOrder.Product.Id, productInOrder.AmountInOrder);
                Console.WriteLine("press 'exit' to finish or 'Enter' to add product");
                toExit = Console.ReadLine();
            }

            s_bl.Order.CalcTotalPrice(order);

            return order;
        }
        private static ProductInOrder BuildProductInOrder(bool isForClubCustomer)
        {
            int productId;
            do
            {
                Console.WriteLine("enter product id");
            } while (!int.TryParse(Console.ReadLine(), out productId));

            int amount;
            do
            {
                Console.WriteLine("enter amount");
            } while (!int.TryParse(Console.ReadLine(), out amount));

            Product product = s_bl.Product.Read(productId);
            ProductInOrder productInOrder = new ProductInOrder(product, amount);
            s_bl.Order.SearchSaleForProduct(isForClubCustomer, productInOrder);
            s_bl.Order.CalcProductTotalPrice(productInOrder);

            return productInOrder;
        }


        private static Func<T, bool> ChooseFilter<T>()
        {
            return x => true;
        }
        private static int GetId(string item)
        {
            int id;
            do
            {
                Console.WriteLine($"enter {item} id");
            } while (!int.TryParse(Console.ReadLine(), out id));
            return id;
        }

    }
}

