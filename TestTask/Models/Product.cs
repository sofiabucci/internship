

namespace TestTask.Models
{
    public class Product
    {
        public Product(string name, double price, string category)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Value cannot be null or empty.", nameof(name));
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.", nameof(price));
            if (!new[] { "electronics", "pets", "books" }.Contains(category))
                throw new ArgumentException("Invalid category.", nameof(category));

            Name = name;
            Price = price;
            Category = category;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
