using NetCoreBookStore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Edition { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
        public string NameAlias { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Discount Discount { get; set; }
    }
}
