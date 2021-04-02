using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Data.Models
{
   public class Smartphon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string  UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
