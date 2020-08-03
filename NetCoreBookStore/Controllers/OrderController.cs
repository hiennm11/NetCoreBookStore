using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Core.Repositories;
using NetCoreBookStore.Data.ViewModel;

namespace NetCoreBookStore.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ShoppingCartRepository _shoppingCart;
        private readonly IOrderRepository _orderRepository;

        public OrderController(ShoppingCartRepository shoppingCart, IOrderRepository orderRepository)
        {
            this._shoppingCart = shoppingCart;
            this._orderRepository = orderRepository;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(OrderVM order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if(_shoppingCart.ShoppingCartItems.Count() == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some pies first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.PlaceOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order. You'll soon enjoy our books!";
            return View();
        }

    }
}
