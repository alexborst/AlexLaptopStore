namespace AlexLaptopStore.Models
{
    public class Product
    {
        public int bestSellingRank { get; set; }
        public string color { get; set; }
        public decimal customerReviewAverage { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public bool onSale { get; set; }
        public decimal percentSavings { get; set; }
        public double regularPrice { get; set; }
        public double salePrice { get; set; }
        public string shortDescription { get; set; }
        public int sku { get; set; }
        public string thumbnailImage { get; set; }
        public string longDescription { get; set; }
    }
}
