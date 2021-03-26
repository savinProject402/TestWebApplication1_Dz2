using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Data.Models
{
   public class ShopNetwork
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }

        public ICollection<Shop> Shops { get; set; }
    }
}
