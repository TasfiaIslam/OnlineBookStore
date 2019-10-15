using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookShortDescription { get; set; }
        public string BookLongDescription { get; set; }
        public decimal BookPrice { get; set; }
        public string BookImageUrl { get; set; }
        public string BookImageThumbnailUrl { get; set; }
        public bool IsPreferredBook { get; set; }
        public bool BookInStock { get; set; }
        public int BookCategoryId { get; set; }
        public virtual BookCategory BookCategory { get; set; }

    }
}
