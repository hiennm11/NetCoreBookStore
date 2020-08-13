using NetCoreBookStore.Core.Entities;
using NetCoreBookStore.Core.ViewModel;

namespace NetCoreBookStore.Service.Repositories
{
    public interface IOrderRepository
    {
        void PlaceOrder(OrderVM orderVM, string userId);   
    }
}