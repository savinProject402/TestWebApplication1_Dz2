using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication1.Models
{
    public class PagingViewModel
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
    }
}