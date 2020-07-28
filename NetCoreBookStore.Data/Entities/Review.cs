using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public Guid BookId { get; set; }
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }

        public Book Book { get; set; }
    }
}
