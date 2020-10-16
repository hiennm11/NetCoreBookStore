using NetCoreBookStore.Core.Entities;
using NetCoreBookStore.Core.ViewModel;

namespace NetCoreBookStore.Core.Repositories
{
    public interface IOrderRepository
    {
        void PlaceOrder(OrderVM orderVM, string userId);   
    }
}