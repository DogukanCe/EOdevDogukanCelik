using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entites.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Adress is required")]
        public string Adress { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
