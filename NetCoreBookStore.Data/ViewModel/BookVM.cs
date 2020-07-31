using NetCoreBookStore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.ViewModel
{
    public class BookVM
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }      
        public double Price { get; set; }
        public string NameAlias { get; set; }
        public string Image { get; set; }
        public int DiscountValue { get; set; }
    }
}
