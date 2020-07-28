using NetCoreBookStore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime Date { get; set; }
        public int DiscountId { get; set; }
        public int ShipperId { get; set; }
        public State State { get; set; }

        public Shipper Shipper { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Discount Discount { get; set; }
    }
}
