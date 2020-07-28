using NetCoreBookStore.Data.Enums;
using System.Collections.Generic;

namespace NetCoreBookStore.Data.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAlias { get; set; }
        public int ParentId { get; set; }
        public Status Status { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }

    }
}