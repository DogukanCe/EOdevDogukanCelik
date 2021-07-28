
using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entites.Concrete
{
   public class Order:IEntity
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        public decimal UnitPrice { get; set; }
        public string Status { get; set; }
        [Required(ErrorMessage = "Adress is required")]
        public string Adress { get; set; }
        public int ProductId { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
