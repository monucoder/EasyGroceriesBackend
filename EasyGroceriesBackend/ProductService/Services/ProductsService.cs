using ProductService.Models;

namespace ProductService.Services;

public class ProductsService : IProductsService
{
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Milk", Description = "The best of cows", Price = 2.5 },
        new Product { Id = 2, Name = "Bread", Description = "Easy toast", Price = 1.2 },
        new Product { Id = 3, Name = "Eggs", Description = "Wild chicken", Price = 3.0 }
    };

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }
}
