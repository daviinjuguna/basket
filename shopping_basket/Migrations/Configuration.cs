namespace shopping_basket.Migrations
{
    using shopping_basket.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<shopping_basket.Model.store.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "shopping_basket.Model.store.Context";
        }

        protected override void Seed(shopping_basket.Model.store.Context context)
        {
            var categories = new List<Category>
            {
                new Category {Name = "Computers and Tablets" },
                new Category{Name = "Screens"},
                new Category{Name="Mobile and Phones"},
                new Category{Name = "Gaming"}
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Products>
    {
new Products {Name = "Lenovo 510", Description = "All in one", Price =631, CategoryID = categories.Single(c=>c.Name == "Computers and Tablets").ID},
new Products {Name = "ASUS Strix GeForce", Description = "GTX1060Grpahics Card 6GB", Price = 573, CategoryID= categories.Single(c=>c.Name == "Computers and Tablets").ID},
new Products {Name = "ASUS VE248", Description = "LED Gaming Monitor",Price = 239, CategoryID= categories.Single(c=>c.Name == "Screens").ID},
new Products {Name = "Samsung S32351", Description = "Full HD LEDMonitor", Price = 369, CategoryID= categories.Single(c=>c.Name == "Screens").ID},
new Products {Name = "Apple Iphone", Description = "32GB 3GB", Price = 260.99M, CategoryID= categories.Single(c=>c.Name == "Mobile and Phones").ID},
new Products {Name = "Microsoft Home 10", Description = "64 bit", Price= 171, CategoryID= categories.Single(c=>c.Name == "Mobile and Phones").ID},
 new Products {Name = "Microsoft XBox One X", Description = "1 TB",Price = 749, CategoryID= categories.Single(c=>c.Name == "Gaming").ID},
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();




        }
    }
}
