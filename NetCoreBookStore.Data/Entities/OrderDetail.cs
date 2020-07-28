using System;

namespace NetCoreBookStore.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public Guid BookId { get; set; }
        public int Amount { get; set; }

        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}