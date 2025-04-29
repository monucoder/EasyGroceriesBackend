using BasketService.Models;

namespace BasketService.Services;

public interface IBasketService
{
    void AddItem(BasketItem item);
    IEnumerable<BasketItem> GetBasketItems();
    void ClearBasket();
}
