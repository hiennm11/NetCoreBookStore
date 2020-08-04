using NetCoreBookStore.Data.Entities;
using NetCoreBookStore.Data.ViewModel;

namespace NetCoreBookStore.Core.Repositories
{
    public interface IOrderRepository
    {
        void PlaceOrder(OrderVM orderVM, string userId);   
    }
}