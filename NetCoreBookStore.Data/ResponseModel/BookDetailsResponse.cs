using NetCoreBookStore.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.ResponseModel
{
    public class BookDetailsResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int DiscountValue { get; set; }
        public List<BookImageVM> Images { get; set; }
    }
}
