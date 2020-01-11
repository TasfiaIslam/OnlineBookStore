using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Data.Interfaces;
using OnlineBookStore.Models;
using OnlineBookStore.ViewModels;

namespace OnlineBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBookRepository _bookRepository;

        public BookController(ICategoryRepository categoryRepository, IBookRepository bookRepository)
        {
            _categoryRepository = categoryRepository;
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                books = _bookRepository.BookList.OrderBy(n => n.BookId);
                currentCategory = "All Books";
            }
            else
            {
                if(string.Equals("Detective",_category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _bookRepository.BookList.Where(P => P.BookCategory.BookCategoryName
                    .Equals("Detective")).OrderBy(n => n.BookId);
                }
                else
                {
                    books = _bookRepository.BookList.Where(P => P.BookCategory.BookCategoryName
                    .Equals("Romantic")).OrderBy(n => n.BookId);
                }
                currentCategory = _category;
            }

            var bookListViewModel = new BookListViewModel
            {
                BookList = books,
                CurrentCategory = currentCategory
            };

            return View(bookListViewModel);
        }
    }
}