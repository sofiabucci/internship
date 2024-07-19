namespace Project.Domain.Models
{
    public class Product
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public double Price { get; set; }
    }
}
