using BasketService.Models;
using BasketService.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasketService.Controllers
{
    [Route("basket")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpPost("add")]
        public IActionResult AddItem(BasketItem item)
        {
            _basketService.AddItem(item);
            return Ok(new { message = "Item added to basket." });
        }

        [HttpGet("items")]
        public IActionResult GetItems()
        {
            var items = _basketService.GetBasketItems();
            return Ok(items);
        }

        [HttpDelete("clear")]
        public IActionResult ClearBasket()
        {
            _basketService.ClearBasket();
            return Ok(new { message = "Basket cleared." });
        }
    }
}
