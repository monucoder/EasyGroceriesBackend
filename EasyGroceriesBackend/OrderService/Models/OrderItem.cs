namespace OrderService.Models;

public class OrderItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double UnitPrice { get; set; }
    public int Quantity { get; set; }
    public bool IsLoyalty { get; set; } = false;
}
