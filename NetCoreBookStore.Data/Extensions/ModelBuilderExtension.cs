using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetCoreBookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBookStore.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1, AuthorName = "Undefined", Description = "Default author of all new book", NameAlias = "undefined"
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Book 01",
                    NameAlias = "book-01",
                    Description = "Seeded book",
                    AvailableQuantity = 100,
                    CreatedDate = DateTime.Now,
                    PublicationDate = DateTime.Now,
                    Edition = 2020,
                    Price = 33000,
                    Status = Enums.Status.Active,                  
                }
            );

            Guid ADMIN_ID = Guid.NewGuid();
            // any guid, but nothing is against to use the same one
            Guid ROLE_ID = ADMIN_ID;
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Admin role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "app-admin@abc.xyz",
                NormalizedEmail = "app-admin@abc.xyz",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = string.Empty,
                FirstName = "Admin",
                LastName = "Admin",
                Dob = DateTime.Now,
                PhoneNumber = "0985123745",
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
