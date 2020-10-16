using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Core.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.BookId });
        }
    }
}
