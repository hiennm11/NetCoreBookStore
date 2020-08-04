using NetCoreBookStore.Data.EF;
using NetCoreBookStore.Data.Entities;
using NetCoreBookStore.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreBookStore.Core.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCartRepository _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCartRepository shoppingCart)
        {
            this._appDbContext = appDbContext;
            this._shoppingCart = shoppingCart;
        }

        public void PlaceOrder(OrderVM orderVM, string userId)
        {
            var order = new Order
            {
                Id = Guid.NewGuid().ToString(),
                OrderTotal = _shoppingCart.GetShoppingCartTotal(),
                Date = DateTime.Now,
                State = Data.Enums.State.Init,
                CustomerName = $"{orderVM.FirstName} {orderVM.LastName}",
                CustomerAddress = orderVM.Address,
                CustomerEmail = orderVM.Email,
                CustomerPhoneNumber = orderVM.PhoneNumber,
                CustomerId = userId,
                User = _appDbContext.Users.FirstOrDefault(m => m.Id.ToString() == userId),
                OrderDetails = new List<OrderDetail>()
            };

            foreach (var item in _shoppingCart.ShoppingCartItems)
            {
                var detail = new OrderDetail
                {
                    Amount = item.Amount,
                    BookId = item.Book.Id,
                    OrderId = order.Id
                };

                order.OrderDetails.Add(detail);
            }

            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
