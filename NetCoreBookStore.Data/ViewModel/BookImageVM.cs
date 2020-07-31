using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.ViewModel
{
    public class BookImageVM
    {
        public string BookId { get; set; }
        public string ImgPath { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }

    }
}
