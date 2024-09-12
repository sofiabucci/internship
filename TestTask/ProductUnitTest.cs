using ExpectedObjects;
using TestTask.Models;

namespace TestTask
{
    public class ProductUnitTest
    {
        Product product = new Product("valid", 0, "pets");

        [Fact]
        public void TestValidProduct()
        {
            //ACT
            var _product = new Product(product.Name, product.Price, product.Category);

            //ASSERT
            product.ToExpectedObject().ShouldMatch(_product);

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void TestInvalidProduct(string name)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Product(name, product.Price, product.Category));
            Assert.Equal("Value cannot be null or empty. (Parameter 'name')", exception.Message);
        }

        [Theory]
        [InlineData(-1)]
        public void TestInvalidPrice(double price)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Product(product.Name, price, product.Category));
            Assert.Equal("Price cannot be negative. (Parameter 'price')", exception.Message);
        }

        [Theory]
        [InlineData("electronics")]
        [InlineData("pets")]
        [InlineData("books")]
        public void TestValidCategory(string category)
        {
            product.Category = category;

            Assert.Equal(category, product.Category);
        }

        [Theory]
        [InlineData("fashion")]
        [InlineData("home")]
        [InlineData("food")]
        public void TestInvalidCategory(string category)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Product(product.Name, product.Price, category));
            Assert.Equal("Invalid category. (Parameter 'category')", exception.Message);
        }
    }
}