using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public GatewayController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts()
        {
            var response = await _httpClient.GetAsync("https://localhost:7066/product/all");
            var content = await response.Content.ReadAsStringAsync();
            return Content(content, "application/json");
        }

        [HttpPost("addtobasket")]
        public async Task<IActionResult> AddToBasket([FromBody] object basketItem)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7245/basket/add", basketItem);
            var content = await response.Content.ReadAsStringAsync();
            return Content(content, "application/json");
        }

        [HttpGet("basketitems")]
        public async Task<IActionResult> GetBasketItems()
        {
            var response = await _httpClient.GetAsync("https://localhost:7245/basket/items");
            var content = await response.Content.ReadAsStringAsync();
            return Content(content, "application/json");
        }

        [HttpDelete("clearbasket")]
        public async Task<IActionResult> ClearBasket()
        {
            var response = await _httpClient.DeleteAsync("https://localhost:7245/basket/clear");
            var content = await response.Content.ReadAsStringAsync();
            return Content(content, "application/json");
        }

        [HttpPost("createorder")]
        public async Task<IActionResult> CreateOrder([FromBody] object order)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7148/order/create", order);
            var content = await response.Content.ReadAsStringAsync();
            return Content(content, "application/json");
        }
    }
}
