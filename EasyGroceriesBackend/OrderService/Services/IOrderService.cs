using OrderService.Models;

namespace OrderService.Services;

public interface IOrderService
{
    Order CreateOrder(Order newOrder);
    IEnumerable<Order> GetAllOrders();
}
