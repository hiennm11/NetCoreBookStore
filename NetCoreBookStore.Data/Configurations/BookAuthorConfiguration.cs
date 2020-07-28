using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Configurations
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(x => new { x.BookId, x.AuthorId });
            builder.HasOne(x => x.Book).WithMany(b => b.BookAuthors).HasForeignKey(f => f.BookId);
            builder.HasOne(x => x.Author).WithMany(b => b.BookAuthors).HasForeignKey(f => f.AuthorId);
        }
    }
}
