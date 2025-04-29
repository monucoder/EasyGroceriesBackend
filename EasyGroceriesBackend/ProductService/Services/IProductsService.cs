using ProductService.Models;

namespace ProductService.Services;
public interface IProductsService
{
    IEnumerable<Product> GetAllProducts();
}
