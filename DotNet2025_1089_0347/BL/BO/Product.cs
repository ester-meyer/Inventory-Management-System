namespace BO
{
    public class Product
    {
        public string? Name { get; set; }
        public DO.Categories? Category { get; set; }
        public double Price { get; set; }
        public int? AmountInStock { get; set; }
        public int Id { get; init; }
        public Product(string? name, DO.Categories? category, double price, int? amountInStock)
        {
            Name = name;
            Category = category;
            Price = price;
            AmountInStock = amountInStock;
        }
        public Product() { }

        public override string ToString()
        {
            return $"product [name =  {Name},  category = {Category}, price = {Price}, amount-in-stock= {AmountInStock}, id = {Id}]";
        }
    }
}
