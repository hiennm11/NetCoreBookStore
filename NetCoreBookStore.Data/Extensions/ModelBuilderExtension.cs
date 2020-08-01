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
            modelBuilder.Entity<Discount>().HasData(
                new Discount
                {
                    Id = Guid.NewGuid().ToString(), Name = "Default", Value = 0
                },
                new Discount
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Test",
                    Value = 10
                }
            );

            var bookList = new List<Book>();
            var random = new Random();
            for (int i = 1; i <= 90; i+=4)
            {
                var book = new Book
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = $"Book {i}",
                    NameAlias = $"book-{i}",
                    AvailableQuantity = 100,
                    CreatedDate = DateTime.Now,
                    PublicationDate = DateTime.Now,
                    Edition = 2020,
                    Price = (double)random.Next(35, 57),
                    Status = Enums.Status.Active,
                    Images = new List<BookImage>()
                };

                book.Description = $"<p>{book.Title} is simply dummy text of the printing and typesetting industry. {book.Title} has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. {book.Title} has been the book. </p>"
                + $"<p>{book.Title}'s Description here  </p>";
                    

                var listImg = new List<BookImage>() 
                {
                    new BookImage { BookId = book.Id, Id = Guid.NewGuid().ToString(), ImgPath = $"/MyStaticFiles/images/{book.NameAlias}.jpg", Sort = 1, Description = book.Title },
                    new BookImage { BookId = book.Id, Id = Guid.NewGuid().ToString(), ImgPath = $"/MyStaticFiles/images/product2.jpg", Sort = 2, Description = book.Title },
                    new BookImage { BookId = book.Id, Id = Guid.NewGuid().ToString(), ImgPath = $"/MyStaticFiles/images/product3.jpg", Sort = 3, Description = book.Title }
                };

                modelBuilder.Entity<BookImage>().HasData(listImg);
                bookList.Add(book);
            }

            modelBuilder.Entity<Book>().HasData(bookList);

            Guid ADMIN_ID = Guid.NewGuid();
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
