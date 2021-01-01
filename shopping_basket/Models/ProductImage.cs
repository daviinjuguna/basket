using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shopping_basket.Models
{
    public class ProductImage
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "File")]
        public string FileName { get; set; }

    }
}