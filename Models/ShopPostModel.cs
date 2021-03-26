using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebApplication1.Models
{
    public class ShopPostModel
    {
        [Display (Name = "Имя")]
        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
    }
}