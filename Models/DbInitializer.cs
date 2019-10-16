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
                            BookName = "Beer",
                            BookPrice = 7.95M,
                            BookShortDescription = "The most widely consumed alcohol",
                            BookLongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/beerL_2.jpg",
                            BookInStock = true,
                            IsPreferredBook = true,
                            BookImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                        },
                        new Book
                        {
                            BookName = "Rum & Coke",
                            BookPrice = 12.95M,
                            BookShortDescription = "Cocktail made of cola, lime and rum.",
                            BookLongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/rumCokeL.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/rumAndCokeS.jpg"
                        },
                        new Book
                        {
                            BookName = "Tequila ",
                            BookPrice = 12.95M,
                            BookShortDescription = "Beverage made from the blue agave plant.",
                            BookLongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/tequilaL.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/tequilaS.jpg"
                        },
                        new Book
                        {
                            BookName = "Wine ",
                            BookPrice = 16.75M,
                            BookShortDescription = "A very elegant alcoholic drink",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/wineL.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/wineS.jpg"
                        },
                        new Book
                        {
                            BookName = "Margarita",
                            BookPrice = 17.95M,
                            BookShortDescription = "A cocktail with sec, tequila and lime",
                            BookCategory = Categories["Alcoholic"],
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookImageUrl = "http://imgh.us/margaritaL.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/margaritaS.jpg"
                        },
                        new Book
                        {
                            BookName = "Whiskey with Ice",
                            BookPrice = 15.95M,
                            BookShortDescription = "The best way to taste whiskey",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/whiskyIceL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/whiskeyS.jpg"
                        },
                        new Book
                        {
                            BookName = "Jägermeister",
                            BookPrice = 15.95M,
                            BookShortDescription = "A German digestif made with 56 herbs",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/jagermeisterL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/jagermeisterS.jpg"
                        },
                        new Book
                        {
                            BookName = "Champagne",
                            BookPrice = 15.95M,
                            BookShortDescription = "That is how sparkling wine can be called",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/champagneL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/champagneS.jpg"
                        },
                        new Book
                        {
                            BookName = "Piña colada ",
                            BookPrice = 15.95M,
                            BookShortDescription = "A sweet cocktail made with rum.",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/pinaColadaL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/pinaColadaS.jpg"
                        },
                        new Book
                        {
                            BookName = "White Russian",
                            BookPrice = 15.95M,
                            BookShortDescription = "A cocktail made with vodka ",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/whiteRussianL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/whiteRussianS.jpg"
                        },
                        new Book
                        {
                            BookName = "Long Island Iced Tea",
                            BookPrice = 15.95M,
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/longTeaL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/islandTeaS.jpg"
                        },
                        new Book
                        {
                            BookName = "Vodka",
                            BookPrice = 15.95M,
                            BookShortDescription = "A distilled beverage with water and ethanol.",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/vodkaL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/vodkaS.jpg"
                        },
                        new Book
                        {
                            BookName = "Gin and tonic",
                            BookPrice = 15.95M,
                            BookShortDescription = "Made with gin and tonic water poured over ice.",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/ginTonicL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/ginTonicS.jpg"
                        },
                        new Book
                        {
                            BookName = "Cosmopolitan",
                            BookPrice = 15.95M,
                            BookShortDescription = "Made with vodka, triple sec, cranberry juice.",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Alcoholic"],
                            BookImageUrl = "http://imgh.us/cosmopolitanL.jpg",
                            BookInStock = false,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/cosmopolitanS.jpg"
                        },
                        new Book
                        {
                            BookName = "Tea ",
                            BookPrice = 12.95M,
                            BookShortDescription = "Made by leaves of the tea plant in hot water.",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Non-alcoholic"],
                            BookImageUrl = "http://imgh.us/teaL.jpg",
                            BookInStock = true,
                            IsPreferredBook = true,
                            BookImageThumbnailUrl = "http://imgh.us/teaS.jpg"
                        },
                        new Book
                        {
                            BookName = "Water ",
                            BookPrice = 12.95M,
                            BookShortDescription = " It makes up more than half of your body weight ",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Non-alcoholic"],
                            BookImageUrl = "http://imgh.us/waterL.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/waterS_1.jpg"
                        },
                        new Book
                        {
                            BookName = "Coffee ",
                            BookPrice = 12.95M,
                            BookShortDescription = " A beverage prepared from coffee beans",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Non-alcoholic"],
                            BookImageUrl = "http://imgh.us/coffeeL.jpg",
                            BookInStock = true,
                            IsPreferredBook = true,
                            BookImageThumbnailUrl = "http://imgh.us/coffeS.jpg"
                        },
                        new Book
                        {
                            BookName = "Kvass",
                            BookPrice = 12.95M,
                            BookShortDescription = "A very refreshing Russian beverage",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Non-alcoholic"],
                            BookImageUrl = "http://imgh.us/kvassL.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/kvassS.jpg"
                        },
                        new Book
                        {
                            BookName = "Juice ",
                            BookPrice = 12.95M,
                            BookShortDescription = "Naturally contained in fruit or vegetable tissue.",
                            BookLongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            BookCategory = Categories["Non-alcoholic"],
                            BookImageUrl = "http://imgh.us/juiceL.jpg",
                            BookInStock = true,
                            IsPreferredBook = false,
                            BookImageThumbnailUrl = "http://imgh.us/juiceS.jpg"
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
                        new BookCategory { BookCategoryName = "Alcoholic", BookCategoryDescription="All alcoholic drinks" },
                        new BookCategory { BookCategoryName = "Non-alcoholic", BookCategoryDescription="All non-alcoholic drinks" }
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

