using TestApp.Models;

namespace TestApp.Services
{
    public class ProductService
    {
        public static List<Product> products = new List<Product>();
        public List<Product> GetProducts => products;
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
