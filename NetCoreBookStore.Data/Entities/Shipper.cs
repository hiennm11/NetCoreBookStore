using System.Collections.Generic;

namespace NetCoreBookStore.Data.Entities
{
    public class Shipper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}