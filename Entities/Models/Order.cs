using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("order")]
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }

        [Required(ErrorMessage = "Order date is required")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Order type is required")]
        [StringLength(255, ErrorMessage = "Order type cannot be longer than 255 characters")]
        public string OrderType { get; set; }

        public Guid CustomerID { get; set; }
    }
}
