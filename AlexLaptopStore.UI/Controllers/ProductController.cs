using AlexLaptopStore.UI.APIClients;
using AlexLaptopStore.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AlexLaptopStore.UI.Controllers
{
    public class ProductController : Controller
    {
        public LaptopStoreClient _client { get; set; }

        public IActionResult Index(int productId)
        {
            var productList = _client.GetProductById(productId);
            var productViewModel = new ProductViewModel();

            return View(productViewModel);
        }
    }
}