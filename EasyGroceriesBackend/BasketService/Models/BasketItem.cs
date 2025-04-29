namespace BasketService.Models;

public class BasketItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public double Price { get; set; }
    public int Quantity { get; set; }
}
