using CoreMVCCodeFirst.Models.Entities;

namespace CoreMVCCodeFirst.Models.Products
{
    public class ProductPageVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}
