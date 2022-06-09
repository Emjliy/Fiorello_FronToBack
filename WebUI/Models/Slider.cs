using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Slider
    {
        public int ID { get; set; }
        public string URL { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
