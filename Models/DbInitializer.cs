using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OnlineBookStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Models
{
    public class DbInitializer
    {
        
            public static void Seed(IServiceProvider applicationBuilder)
            {
              AppDbContext context =
              applicationBuilder.GetRequiredService<AppDbContext>();


            if (!context.BookCategories.Any())
                {
                    context.BookCategories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Books.Any())
                {
                    context.AddRange
                    (
                        new Book
                        {
                            BookName = "Sherlock Holmes",
                            BookPrice = 7.95M,
                            BookShortDescription = "A famous detective story",
                            BookLongDescription = "Sherlock Holmes (/ˈʃɜːrlɒk ˈhoʊmz/ or /-ˈhoʊlmz/) is a fictional private detective created by British author Sir Arthur Conan Doyle. Referring to himself as a consulting detective in the stories",
                            BookCategory = Categories["Detective"],
                            BookImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91dDv9WOcFL.jpg",
                            BookInStock = true,
                            IsPreferredBook = true,
                            BookImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/91dDv9WOcFL.jpg"
                        },
                        new Book
                        {
                            BookName = "Kolkatay Feluda",
                            BookPrice = 12.95M,
                            BookShortDescription = "Written by Shatyajeet Roy",
                            BookLongDescription = "Feluda is often accompanied by his cousin Tapesh Ranjan Mitra (affectionately called Topshe by Feluda), who serves as the narrator of the stories. From the sixth story, Sonar Kella (The Golden Fortress), the duo are joined by a popular thriller writer Jatayu (Lalmohon Ganguli).",
                            BookCategory = Categories["Detective"],
                            BookImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51tN0fA8M-L._SX313_BO1,204,203,200_.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/51tN0fA8M-L._SX313_BO1,204,203,200_.jpg"
                        },                                                                     
                        new Book
                        {
                            BookName = "The Notebook",
                            BookPrice = 12.95M,
                            BookShortDescription = "By American novelist Nicholas Sparks",
                            BookLongDescription = "The Notebook is a 1996 romantic novel by American novelist Nicholas Sparks, The novel was later adapted into a popular film of the same name, in 2004. The Indian Bollywood film, Zindagi Tere Naam, starring Mithun Chakraborty, is also based on it.",
                            BookCategory = Categories["Romantic"],
                            BookImageUrl = "https://images-na.ssl-images-amazon.com/images/I/514q4BDBzfL._SX315_BO1,204,203,200_.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/514q4BDBzfL._SX315_BO1,204,203,200_.jpg"
                        }
                    );
                }

                context.SaveChanges();
            }

            private static Dictionary<string, BookCategory> categories;
            public static Dictionary<string, BookCategory> Categories
            {
                get
                {
                    if (categories == null)
                    {
                        var genresList = new BookCategory[]
                        {
                        new BookCategory { BookCategoryName = "Detective", BookCategoryDescription="All detective books" },
                        new BookCategory { BookCategoryName = "Romantic", BookCategoryDescription="All romantic books" }
                        };

                        categories = new Dictionary<string, BookCategory>();

                        foreach (BookCategory genre in genresList)
                        {
                            categories.Add(genre.BookCategoryName, genre);
                        }
                    }

                    return categories;
                }
            }
        }

    }

