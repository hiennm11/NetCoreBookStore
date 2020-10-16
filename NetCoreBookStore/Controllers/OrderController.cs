using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Core.Repositories;
using NetCoreBookStore.Core.Entities;
using NetCoreBookStore.Core.ViewModel;

namespace NetCoreBookStore.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ShoppingCartRepository _shoppingCart;
        private readonly IOrderRepository _orderRepository;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(ShoppingCartRepository shoppingCart, IOrderRepository orderRepository, UserManager<AppUser> userManager)
        {
            this._shoppingCart = shoppingCart;
            this._orderRepository = orderRepository;
            this._userManager = userManager;
        }

        public async Task<IActionResult> Checkout()
        {
            var user = await _userManager.GetUserAsync(User);
            var orderVM = new OrderVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return View(orderVM);
        }

        [HttpPost]
        public IActionResult Checkout(OrderVM order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if(_shoppingCart.ShoppingCartItems.Count() == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some books first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.PlaceOrder(order, _userManager.GetUserId(User));
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
