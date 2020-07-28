﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Entities
{
    public class BookGenre
    {
        public Guid BookId { get; set; }
        public int GenreId { get; set; }
        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}
