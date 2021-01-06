using shopping_basket.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace shopping_basket.Model.store
{
    public class Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Context() : base("name=Context")
        {
        }

        public System.Data.Entity.DbSet<shopping_basket.Models.Brand> Categories { get; set; }

        public System.Data.Entity.DbSet<shopping_basket.Models.Products> Products { get; set; }
        public System.Data.Entity.DbSet<shopping_basket.Models.ProductImage> ProductImages { get; set; }
        public DbSet<BasketLine> BasketLines { get; set; }


        public System.Data.Entity.DbSet<shopping_basket.ViewModel.RoleViewModel> RoleViewModels { get; set; }

        public System.Data.Entity.DbSet<shopping_basket.Models.Order> Orders { get; set; }
        public DbSet<OrderLine> Orderlines { get; set; }
    }
}
