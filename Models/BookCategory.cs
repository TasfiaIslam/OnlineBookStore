using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class BookCategory
    {
        public int BookCategoryId { get; set; }
        public string BookCategoryName { get; set; }
        public string BookCategoryDescription { get; set; }
        public List<Book> BookList { get; set; }
    }
}
