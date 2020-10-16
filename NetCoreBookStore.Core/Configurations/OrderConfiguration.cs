using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Core.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.OrderDetails).WithOne(s => s.Order).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
