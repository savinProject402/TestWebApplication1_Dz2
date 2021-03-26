using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Domain.Model
{
   public class ShopNetworkModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }

        public ICollection<ShopModel> Shops { get; set; }
    }
}
