using Smartphones.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Domain.Contracs
{
    public interface IShopNetworkService
    {
        IReadOnlyCollection<ShopNetworkModel> GetByUserId(string userId);
        void EditShop(int networkId, int shopId, string requestorId);

    }
}
