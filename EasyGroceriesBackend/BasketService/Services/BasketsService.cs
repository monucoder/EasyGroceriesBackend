using BasketService.Models;

namespace BasketService.Services;

public class BasketsService : IBasketService
{
    private readonly List<BasketItem> _basket = new();

    public void AddItem(BasketItem item)
    {
        var existing = _basket.Find(x => x.ProductId == item.ProductId);
        if (existing != null)
        {
            existing.Quantity += item.Quantity;
        }
        else
        {
            _basket.Add(item);
        }
    }

    public IEnumerable<BasketItem> GetBasketItems()
    {
        return _basket;
    }

    public void ClearBasket()
    {
        _basket.Clear();
    }
}
