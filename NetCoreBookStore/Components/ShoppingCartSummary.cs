using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Service.Repositories;
using NetCoreBookStore.Models;

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
