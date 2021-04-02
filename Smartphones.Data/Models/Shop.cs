using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Data.Models
{
   public class Shop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public int? NetworkId { get; set; }
        public ShopNetwork Network { get; set; }

        public ICollection<Smartphon> Smartphons { get; set; }
    }
}
