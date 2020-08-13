using System;

namespace NetCoreBookStore.Core.Entities
{
    public class OrderDetail
    {
        public string OrderId { get; set; }
        public string BookId { get; set; }
        public int Amount { get; set; }

        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}