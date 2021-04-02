using Smartphones.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebApplication1.Models
{
    public class SmartphonPostModel
    {
        [Display(Name = "Имя")]
        public string Name { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }

    }
}