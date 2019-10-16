using OnlineBookStore.Data.Interfaces;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Book> BookList => _appDbContext.Books.Include(c => c.BookCategory);

        public IEnumerable<Book> PreferredBooks => _appDbContext.Books.Where(p => p.IsPreferredBook).Include(c => c.BookCategory);

        public Book GetBookById(int bookId) => _appDbContext.Books.FirstOrDefault(p => p.BookId == bookId);
    }
}
