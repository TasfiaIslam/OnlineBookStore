using OnlineBookStore.Data.Interfaces;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Data.Repositories
{
    public class BookCategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<BookCategory> BookCategories => _appDbContext.BookCategories;
    }
}
