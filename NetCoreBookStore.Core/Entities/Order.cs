using NetCoreBookStore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Core.Entities
{
    public class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string DiscountId { get; set; }
        public State State { get; set; }
        public double OrderTotal { get; set; }

        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }


        public AppUser User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Discount Discount { get; set; }
    }
}
