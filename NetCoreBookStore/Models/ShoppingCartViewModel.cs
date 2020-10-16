using NetCoreBookStore.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBookStore.Models
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartRepository ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}
