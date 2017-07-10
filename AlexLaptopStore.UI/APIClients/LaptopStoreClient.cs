using AlexLaptopStore.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Net.Http;

namespace AlexLaptopStore.UI.APIClients
{
    public class LaptopStoreClient
    {
        const string apiurl = "https://api.bestbuy.com/v1/products";
        const string apiKey = "3z6a6dd2jyfjtrpkhdbsaayk";
        public HttpClient _client;

        public LaptopStoreClient()
        {
            _client = new HttpClient();
            //_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
        }

        public List<Product> GetAllProducts()
        {
            string url = apiurl + "?" + apiKey + "&format=json";
            var response = _client.GetAsync("https://api.bestbuy.com/v1/products?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&format=json").Result;
            string stringData = response.Content.ReadAsStringAsync().Result;
            ProductListReturn productListReturn = JsonConvert.DeserializeObject<ProductListReturn>(stringData);

            return productListReturn.products;
        }

        public Product GetProductById(int productId)
        {
            var response = _client.GetAsync(apiurl).Result;
            string stringData = response.Content.ReadAsStringAsync().Result;
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(stringData);

            return productList.Find(f => f.sku == productId);
        }
        public List<Product> GetShoppingCart()
        {
            //var response = _client.GetAsync(apiurl).Result;
            //string stringData = response.Content.ReadAsStringAsync().Result;
            //List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(stringData);

            var productList = new List<Product>()
            {
                new Product(){name = "Product1", sku = 12345, longDescription = "longDescription 1", salePrice = 12.95},
                new Product(){name = "Product2", sku = 34567, longDescription = "longDescription 2", salePrice = 38.95},
                new Product(){name = "Product3", sku = 56789, longDescription = "longDescription 3", salePrice = 6.95}
            };

            return productList;
        }       
    }
}
