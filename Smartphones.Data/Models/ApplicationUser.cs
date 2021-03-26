using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Data.Models
{
   public class ApplicationUser : IdentityUser
    {
        public ICollection<Smartphon> Smartphones { get; set; }
        public ICollection<ShopNetwork> Networks { get; set; }
    }
}
