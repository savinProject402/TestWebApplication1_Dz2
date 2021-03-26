using Smartphones.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Data.Contract
{
    public interface IShopsRepository
    {
        void Create(Shop model);
        IReadOnlyCollection<Shop> GetAll();
        Shop GetById(int id);
        void Update(Shop model);
    }
}
