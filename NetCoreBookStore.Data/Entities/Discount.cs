using System.Collections.Generic;

namespace NetCoreBookStore.Data.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Value { get; set; }

        public ICollection<Book> Books { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}