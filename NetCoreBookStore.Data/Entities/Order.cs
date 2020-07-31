using NetCoreBookStore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Entities
{
    public class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string DiscountId { get; set; }
        public State State { get; set; }

        public AppUser User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Discount Discount { get; set; }
    }
}
