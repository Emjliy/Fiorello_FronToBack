using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
