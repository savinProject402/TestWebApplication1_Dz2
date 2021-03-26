using Smartphones.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Domain.Contracs
{
    public interface IShopServices
    {
        void Create(ShopModel model);
        IReadOnlyCollection<ShopModel> GetAll();
        ShopModel GetById(int Id);
        void Update(ShopModel model);
    }
}
