using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Data.Interfaces;
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

        public IActionResult List()
        {         
            BookListViewModel bookvm = new BookListViewModel();
            bookvm.BookList = _bookRepository.BookList;
            bookvm.CurrentCategory = "BookCategory";
            return View(bookvm);
        }
    }
}