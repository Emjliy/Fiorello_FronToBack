using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int Discount { get; set; }
        public ICollection<ProductImage> Images { get; set; }
    }
}
