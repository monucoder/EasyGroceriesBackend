using OrderService.Models;

namespace OrderService.Services;

public class OrdersService : IOrderService
{
    private readonly List<Order> _orders = new();
    private int _orderCounter = 1000;

    public Order CreateOrder(Order newOrder)
    {
        double total = 0.0;
        bool loyaltyPurchased = newOrder.Items.Exists(x => x.IsLoyalty);

        foreach (var item in newOrder.Items)
        {
            double price = item.UnitPrice * item.Quantity;

            if (loyaltyPurchased && !item.IsLoyalty)
            {
                price *= 0.8; // 20% discount
            }

            total += price;
        }

        if (loyaltyPurchased)
        {
            // Loyalty Membership Cost (£5) - Not discounted
            total += 5.0;
        }

        newOrder.TotalAmount = Math.Round(total, 2);
        newOrder.OrderNumber = ++_orderCounter;

        _orders.Add(newOrder);

        return newOrder;
    }

    public IEnumerable<Order> GetAllOrders()
    {
        return _orders;
    }
}
