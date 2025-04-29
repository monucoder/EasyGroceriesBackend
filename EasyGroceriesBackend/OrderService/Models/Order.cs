namespace OrderService.Models;

public class Order
{
    public int CustomerId { get; set; }
    public List<OrderItem> Items { get; set; } = new();
    public string ShippingAddress { get; set; } = null!;
    public bool IncludeLoyalty { get; set; }
    public double TotalAmount { get; set; }
    public int OrderNumber { get; set; }
}
