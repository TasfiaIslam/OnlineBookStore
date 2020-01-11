using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int NumberOfBooks { get; set; }
        public decimal BookPrice { get; set; }
        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}
