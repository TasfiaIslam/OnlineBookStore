using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<BookCategory> BookCategories { get; }
    }
}
