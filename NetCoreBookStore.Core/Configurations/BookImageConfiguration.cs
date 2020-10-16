using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Core.Configurations
{
    public class BookImageConfiguration : IEntityTypeConfiguration<BookImage>
    {
        public void Configure(EntityTypeBuilder<BookImage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ImgPath).IsRequired();

            builder.HasOne(x => x.Book).WithMany(s => s.Images).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
