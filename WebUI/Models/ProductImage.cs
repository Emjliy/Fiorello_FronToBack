using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class ProductImage
    {

        public int ID { get; set; }
        public int ProductID { get; set; }
        public string URL { get; set; }
        public Product Product { get; set; }


    }
}
