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
        }
    }
}
