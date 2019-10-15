using OnlineBookStore.Data.Interfaces;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Data.Mocks
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<BookCategory> BookCategories
        {
            get
            {
                return new List<BookCategory>
                {
                    new BookCategory{BookCategoryName="Detective",BookCategoryDescription="All detective books"},
                    new BookCategory{BookCategoryName="Thriller",BookCategoryDescription="All thriller books"},
                };
            }
        }
    }
}
