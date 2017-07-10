using AlexLaptopStore.UI.APIClients;
using AlexLaptopStore.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlexLaptopStore.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        public LaptopStoreClient _client { get; set; }
        public ShoppingCartController()
        {
            _client = new LaptopStoreClient();
        }

        public IActionResult Index()
        {
            var productList = _client.GetShoppingCart();
            var productListViewModel = new ProductListViewModel() { Products = productList };

            return View(productListViewModel);
        }
    }
}
