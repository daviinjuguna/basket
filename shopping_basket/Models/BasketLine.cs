using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;
using Xunit.Sdk;

namespace shopping_basket.Models
{
    public class BasketLine
    {
        [Key]
        public int ID { get; set; }
        public string BasketID { get; set; }
        public int ProductID { get; set; }
        [Range(0, 50, ErrorMessage = "Please enter a quantity between 0 and 50")]
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Products Product { get; set; }

    }
}