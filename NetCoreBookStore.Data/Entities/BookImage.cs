using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Entities
{
    public class BookImage
    {
        public string Id { get; set; }
        public string BookId { get; set; }
        public string ImgPath { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }

        public Book Book { get; set; }
    }
}
