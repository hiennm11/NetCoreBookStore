using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Configurations
{
    public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();

            builder.HasMany(x => x.Orders).WithOne(s => s.Shipper);
        }
    }
}
