using AlexLaptopStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AlexLaptopStore.UI.APIControllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            throw new System.Exception();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
