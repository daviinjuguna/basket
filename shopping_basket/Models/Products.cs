using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shopping_basket.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }

        [Display(Name = "Brand")]
        public virtual Brand Category { get; set; }
    }
}