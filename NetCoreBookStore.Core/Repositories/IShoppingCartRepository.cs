using NetCoreBookStore.Core.Entities;
using System.Collections.Generic;

namespace NetCoreBookStore.Core.Repositories
{
    public interface IShoppingCartRepository
    {
        string ShoppingCartId { get; set; }
        List<ShoppingCartItem> ShoppingCartItems { get; set; }

        void AddToCart(Book book, int amount);
        void ClearCart();
        List<ShoppingCartItem> GetShoppingCartItems();
        double GetShoppingCartTotal();
        int RemoveFromCart(Book book);
    }
}