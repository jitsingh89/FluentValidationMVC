using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationMVC.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}