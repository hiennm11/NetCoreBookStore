using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(15).IsRequired();
            builder.Property(x => x.Dob).IsRequired();

            builder.HasMany(x => x.Orders).WithOne(s => s.User);
        }
    }
}
