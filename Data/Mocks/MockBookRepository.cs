using OnlineBookStore.Data.Interfaces;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Data.Mocks
{
    public class MockBookRepository:IBookRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Book> BookList
        {
            get
            {
                return new List<Book>
                {
                    new Book {
                        BookName = "The Adventures of Sherlock Holmes",
                        BookPrice = 7.5M, BookShortDescription = "This is a famous detective story",
                        BookLongDescription = "The Adventures of Sherlock Holmes is a collection of twelve detective stories of Sir Arthur Conan Doyle's most famous literary creation, Sherlock Holmes.",
                        BookCategory = _categoryRepository.BookCategories.First(),
                        BookImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR9cXIemO5GVz4lOm96MhTmVmnNGCiFlT7d9UMohs77XsLJRxlZ",
                        BookInStock = true,
                        IsPreferredBook = true,
                        BookImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRDmq8tlL_2XoTxPoOFjFgPur1Jx5n_-cNLXNF1ofYfbVnj4gtQ"
                    },
                    new Book {
                        BookName = "Feluda Samagra Vol. I & II",
                        BookPrice = 12.95M, BookShortDescription = "Bengali Detective Book",
                        BookLongDescription = "Pradosh Chandra Mitra (Mitter), the private detective, is the main character in a series of detective stories written by Satyajit Ray. More familiarly known by his nickname, Feluda, Pradosh Chandra Mitra is a Bengali detective who solves mysteries using his incisive intellect.",
                        BookCategory =  _categoryRepository.BookCategories.First(),
                        BookImageUrl = "https://images-na.ssl-images-amazon.com/images/I/31E8GUfBdiL._BO1,204,203,200_.jpg",
                        BookInStock = true,
                        IsPreferredBook = false,
                        BookImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/31E8GUfBdiL._BO1,204,203,200_.jpg"
                    },
                    new Book {
                        BookName = "BYOMKESH SAMAGRA",
                        BookPrice = 12.95M,
                        BookShortDescription = "Bengali Detective Book",
                        BookLongDescription = "Bengali Detective Book | BYOMKESH SAMAGRA | All Stories of Byomkesh | Sharadindu Bandyopadhyay",
                        BookCategory = _categoryRepository.BookCategories.First(),
                        BookImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51BREk1SrZL._SX333_BO1,204,203,200_.jpg",
                        BookInStock = true,
                        IsPreferredBook = false,
                        BookImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/51BREk1SrZL._SX333_BO1,204,203,200_.jpg"
                    },
                    new Book
                    {
                        BookName = "SHANKU SAMAGRA",
                        BookPrice = 12.95M,
                        BookShortDescription = "Bengali Science Fiction Book",
                        BookLongDescription = "Bengali Popular Science Fiction Books | SHANKU | SHANKU SAMAGRA | By Satyajit Ray",
                        BookCategory = _categoryRepository.BookCategories.Last(),
                        BookImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41QKji8LSlL._SX324_BO1,204,203,200_.jpg",
                        BookInStock = true,
                        IsPreferredBook = false,
                        BookImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/41QKji8LSlL._SX324_BO1,204,203,200_.jpg"
                    }
                };
            }
        }
        public IEnumerable<Book> PreferredBooks { get; }

        public Book GetBookById(int BookId)
        {
            throw new NotImplementedException();
        }

    }
}
