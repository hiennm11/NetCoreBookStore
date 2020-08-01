using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Core.Repositories;
using NetCoreBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBookStore.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCartRepository _shoppingCart;

        public ShoppingCartSummary(ShoppingCartRepository shoppingCart)
        {
            this._shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartVM);
        }
    }
}
