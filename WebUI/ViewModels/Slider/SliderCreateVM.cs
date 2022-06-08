using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewModels.Slider
{
    public class SliderCreateVM
    {
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
