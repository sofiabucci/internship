namespace Project.Domain.Models
{
    public class Product
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
