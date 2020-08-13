using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Service.Repositories;
using NetCoreBookStore.Models;

namespace NetCoreBookStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ShoppingCartRepository _shoppingCart;

        public ShoppingCartController(IBookRepository bookRepository, ShoppingCartRepository shoppingCart)
        {
            this._bookRepository = bookRepository;
            this._shoppingCart = shoppingCart;
        }

        public IActionResult Index()
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

        public RedirectToActionResult AddToShoppingCart(string bookId)
        {
            var selectedBook = _bookRepository.GetBookEntityById(bookId);

            if (selectedBook != null)
            {
                _shoppingCart.AddToCart(selectedBook, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(string bookId)
        {
            var selectedBook = _bookRepository.GetBookEntityById(bookId);

            if (selectedBook != null)
            {
                _shoppingCart.RemoveFromCart(selectedBook);
            }
            return RedirectToAction("Index");
        }
    }
}
