using System.Collections.Generic;

namespace AlexLaptopStore.Models
{
    public class ProductListReturn
    {
        public int from { get; set; }
        public int to { get; set; }
        public int currentPage { get; set; }
        public int total { get; set; }
        public int totalPages { get; set; }
        public decimal queryTime { get; set; }
        public decimal totalTime { get; set; }
        public int partial { get; set; }
        public string canonicalUrl { get; set; }
        public List<Product> products { get; set; }
    }
}
