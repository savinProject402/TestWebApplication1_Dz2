using Smartphones.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Data.Contract
{
    public interface IShopNetworkRepository
    {
        IReadOnlyCollection<ShopNetwork> GetByUserId(string userId);
    }
}
