using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Configurations
{
    public class BookGenreConfiguration : IEntityTypeConfiguration<BookGenre>
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            builder.HasKey(x => new { x.BookId, x.GenreId });
            builder.HasOne(x => x.Book).WithMany(b => b.BookGenres).HasForeignKey(f => f.BookId);
            builder.HasOne(x => x.Genre).WithMany(b => b.BookGenres).HasForeignKey(f => f.GenreId);
        }
    }
}
