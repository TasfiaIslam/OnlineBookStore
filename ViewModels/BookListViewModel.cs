using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> BookList { get; set; }
        public string CurrentCategory { get; set; }
    }
}
