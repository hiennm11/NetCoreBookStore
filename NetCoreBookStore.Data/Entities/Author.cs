using System.Collections.Generic;

namespace NetCoreBookStore.Data.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string StageName { get; set; }
        public string Description { get; set; }
        public string NameAlias { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}