using Smartphones.Domain.Model;
using Smartphones.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones.Domain.Contracs
{
   public interface ISmartphonesServices
    {
          IReadOnlyCollection<SmartphonesModel> GetAll();
    }
}
