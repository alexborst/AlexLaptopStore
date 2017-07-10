using Microsoft.AspNetCore.Mvc;
using AlexLaptopStore.UI.APIClients;
using AlexLaptopStore.UI.ViewModels;

namespace AlexLaptopStore.UI.Controllers
{
    public class HomeController : Controller
    {
        public LaptopStoreClient _client { get; set; }
        public HomeController()
        {
            _client = new LaptopStoreClient();
        }

        public IActionResult Index()
        {
            var productList = _client.GetAllProducts();
            var productListViewModel = new ProductListViewModel() {Products = productList };

            return View(productListViewModel);
        }

        #region Template stuff
        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View();
        //}
        #endregion
    }
}
