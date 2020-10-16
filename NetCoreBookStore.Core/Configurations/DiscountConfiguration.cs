using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Core.Configurations
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Value).IsRequired();

            builder.HasMany(x => x.Books).WithOne(s => s.Discount).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.Orders).WithOne(s => s.Discount);
        }
    }
}
