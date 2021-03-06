﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Core.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.PublicationDate).IsRequired();
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
