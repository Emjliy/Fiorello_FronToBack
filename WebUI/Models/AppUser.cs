using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public bool isActivated { get; set; }
    }
}
