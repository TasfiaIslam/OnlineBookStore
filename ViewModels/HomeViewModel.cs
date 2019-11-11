using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> PreferredBooks { get; set; }
    }
}
