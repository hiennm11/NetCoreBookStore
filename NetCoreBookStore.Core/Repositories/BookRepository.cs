using Microsoft.EntityFrameworkCore;
using NetCoreBookStore.Data.EF;
using NetCoreBookStore.Data.ResponseModel;
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
        IEnumerable<BookVM> GetAll();
        IEnumerable<BookVM> GetRecomendedBooks();
        Task<IEnumerable<BookVM>> GetAllAsync();
        Task<IEnumerable<BookVM>> GetRecomendedBooksAsync();
        Task<IEnumerable<BookVM>> GetPagingAsync(int page, int pageSize);
        Task<BookDetailsResponse> GetSingleAsync(string Id);

    }

    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _dbContext;

        public BookRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<BookVM> GetAll()
        {           
            return _dbContext.Books.Select(x => new BookVM
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                NameAlias = x.NameAlias,
                Price = x.Price,
                Image = _dbContext.BookImages.FirstOrDefault(s => s.BookId == x.Id && s.Sort == 1).ImgPath
            }).ToList();
        }

        public async Task<IEnumerable<BookVM>> GetAllAsync()
        {
            return await _dbContext.Books.Select(x => new BookVM
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                NameAlias = x.NameAlias,
                Price = x.Price,
                Image = _dbContext.BookImages.FirstOrDefault(s => s.BookId == x.Id && s.Sort == 1).ImgPath,
            }).ToListAsync();
        }

        public async Task<IEnumerable<BookVM>> GetPagingAsync(int page, int pageSize)
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

        public IEnumerable<BookVM> GetRecomendedBooks()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookVM>> GetRecomendedBooksAsync()
        {
            return await _dbContext.Books.OrderBy(m => m.CreatedDate).Select(x => new BookVM
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                NameAlias = x.NameAlias,
                Price = x.Price,
                Image = _dbContext.BookImages.FirstOrDefault(s => s.BookId == x.Id && s.Sort == 1).ImgPath,
            }).Take(4).ToListAsync();
        }

        public async Task<BookDetailsResponse> GetSingleAsync(string Id)
        {
            var book = await _dbContext.Books.Select(m => new BookDetailsResponse
            {
                Id = m.Id,
                Description = m.Description,
                Price = m.Price,
                Title = m.Title
            }).FirstOrDefaultAsync(x => x.Id == Id);

            var imgList = _dbContext.BookImages.Where(x => x.BookId == book.Id)
                .Select(s => new BookImageVM
                {
                    BookId = s.BookId, 
                    Description = s.Description, 
                    ImgPath = s.ImgPath,
                    Sort = s.Sort
                });

            book.Images = imgList.ToList();

            return book;
        }
    }
}
