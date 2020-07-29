using Microsoft.EntityFrameworkCore;
using NetCoreBookStore.Data.EF;
using NetCoreBookStore.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreBookStore.Core.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookVM>> GetAllBookAsync();
        Task<IEnumerable<BookVM>> GetBookPagingAsync(int page, int pageSize);

    }

    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _dbContext;

        public BookRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<BookVM>> GetAllBookAsync()
        {
            return await _dbContext.Books.Select(x => new BookVM
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                NameAlias = x.NameAlias,
                Price = x.Price
            }).ToListAsync();
        }

        public async Task<IEnumerable<BookVM>> GetBookPagingAsync(int page, int pageSize)
        {
            return await _dbContext.Books.Select(x => new BookVM
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                NameAlias = x.NameAlias,
                Price = x.Price
            }).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}
