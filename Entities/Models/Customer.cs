using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, ErrorMessage = "First name can't be longer than 100 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100, ErrorMessage = "Last name can't be longer than 100 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date joined is required")]
        public DateTime DateJoined { get; set; }
    }
}
