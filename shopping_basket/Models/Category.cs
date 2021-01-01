using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace shopping_basket.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="Brand")]
        public string Name { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}