using System.Collections.Generic;
namespace DttBaiTapLab.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public int Id { get; set; }
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Title = "Nồi cơm điện cao tầng Nagakawa NAG0102",
                    Image = "/images/image1.png"
                },
                new Product()
                {
                    Id = 2,
                    Title = "Nồi cơm điện cao tầng Nagakawa NAG0102",
                    Image = "/images/image1.png"
                },
                new Product()
                {
                    Id = 3,
                    Title = "Nồi cơm điện cao tầng Nagakawa NAG0102",
                    Image = "/images/image1.png"
                }
            };
            return products;
        }
    }
}
