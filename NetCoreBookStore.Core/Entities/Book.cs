using NetCoreBookStore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Core.Entities
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Edition { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
        public string NameAlias { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<BookImage> Images { get; set; }
        public Discount Discount { get; set; }
    }
}
