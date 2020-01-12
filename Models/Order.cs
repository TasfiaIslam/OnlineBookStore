using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail> OrderLines { get; set; }

        [Display(Name="First Name")]
        [StringLength(50)]
        [Required(ErrorMessage ="Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
