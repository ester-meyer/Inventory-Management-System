namespace BO
{
    public class Product
    {
        
        public string? Name { get; set; }
        public Categories? Category { get; set; }
        public double Price { get; set; }
        public int? AmountInStock { get; set; }
        public int Id { get; init; }
        public Product(string? name, Categories? category, double price, int? amountInStock, int id)
        {
            Name = name;
            Category = category;
            Price = price;
            AmountInStock = amountInStock;
            Id = id;
        }
        public Product() { }

        public override string ToString()
        {
            return string.Format("name=", Name, " category=", Category ," price=", Price, " amount-in-stock=", AmountInStock," id=",Id);
        }
    }
}
