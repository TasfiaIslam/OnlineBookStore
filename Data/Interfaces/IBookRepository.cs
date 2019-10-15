using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Data.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> BookList { get; }
        IEnumerable<Book> PreferredBooks { get;}
        Book GetBookById(int BookId);
    }
}
