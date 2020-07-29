using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
        }
    }
}
