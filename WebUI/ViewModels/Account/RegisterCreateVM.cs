using Lucene.Net.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewModels.Account
{
    public class RegisterCreateVM
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }

        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password),Compare(nameof(Password),ErrorMessage ="Password doesn't match ")]
        public string CheckPassword { get; set; }

    }
}
